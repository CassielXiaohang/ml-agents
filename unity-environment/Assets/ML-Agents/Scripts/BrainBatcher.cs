﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Google.Protobuf;

namespace MLAgents
{

    public class BrainBatcher
    {
        const int NUM_AGENTS = 32;
        Dictionary<string, bool> hasSentState = new Dictionary<string, bool>();
        Dictionary<string, bool> triedSendState = new Dictionary<string, bool>();

        Dictionary<string, List<Agent>> currentAgents = new Dictionary<string, List<Agent>>();
        Communicator.Communicator communicator;
        Communicator.UnityRLOutput unityOutput = new Communicator.UnityRLOutput();

        bool academyDone;
        Communicator.Command command = Communicator.Command.Reset;
        Communicator.EnvironmentParameters environmentParameters;

        // TO delete
        //Academy academy;

        public BrainBatcher(Communicator.Communicator communicator)
        {
            this.communicator = communicator;
            // This needs to disapear, the done flag of the academy should be accessible by everything
            //academy = Object.FindObjectOfType<Academy>() as Academy;

        }

        public void GiveAcademyParameters(Communicator.AcademyParameters academyParameters)
        {
            Communicator.UnityRLInput input;
            communicator.Initialize(academyParameters, out input);
            command = input.Command;
            environmentParameters = input.EnvironmentParameters;
        }

        /// <summary>
        /// Adds the done flag of the academy to the next output to be sent
        /// to the communicator.
        /// </summary>
        /// <param name="done">If set to <c>true</c> 
        /// The academy is done.</param>
        public void GiveAcademyDone(bool done)
        {
            academyDone = done;
        }

        public Communicator.Command GetCommand()
        {
            return command;
        }

        public Communicator.EnvironmentParameters GetEnvironmentParameters()
        {
            return environmentParameters;
        }

        /// <summary>
        /// Adds the brain to the list of brains which have already decided their
        /// actions.
        /// </summary>
        /// <param name="brainKey">Brain key.</param>
        public void SubscribeBrain(string brainKey)
        {
            triedSendState[brainKey] = false;
            hasSentState[brainKey] = false;
            currentAgents[brainKey] = new List<Agent>(NUM_AGENTS);
            unityOutput.AgentInfos.Add(brainKey, new Communicator.UnityRLOutput.Types.ListAgentInfo());
        }

        /// <summary>
        /// Converts a AgentInfo to a protobuffer generated AgentInfo
        /// </summary>
        /// <returns>The Proto agentInfo.</returns>
        /// <param name="info">The AgentInfo to convert.</param>
        private static Communicator.AgentInfo AgentInfoConvertor(AgentInfo info)
        {
            Communicator.AgentInfo ai = new Communicator.AgentInfo();
            ai.VectorObservation.AddRange(info.vectorObservation);
            ai.StackedVectorObservation.AddRange(info.stackedVectorObservation);
            ai.StoredVectorActions.AddRange(info.storedVectorActions);
            //TODO : Visual Observations, memories and text action
            ai.Reward = info.reward;
            ai.MaxStepReached = info.maxStepReached;
            ai.Done = info.done;
            ai.Id = info.id;
            return ai;
        }

        /// <summary>
        /// Gives the brain info.
        /// </summary>
        /// <param name="brainKey">Brain key.</param>
        /// <param name="agentInfo">Agent info.</param>
        public void GiveBrainInfo(string brainKey, Dictionary<Agent, AgentInfo> agentInfo)
        {
            //TODO : Find a way to remove this academy




            if (communicator == null)
            {
                return;
            }

            triedSendState[brainKey] = true;
            currentAgents[brainKey].Clear();
            foreach (Agent agent in agentInfo.Keys)
            {
                currentAgents[brainKey].Add(agent);
            }
            if (currentAgents[brainKey].Count > 0)
            {

                //Communicator.UnityOutput.Types.ListAgentInfo listAgentInfo =
                //new Communicator.UnityOutput.Types.ListAgentInfo();
                unityOutput.AgentInfos[brainKey].Value.Clear();
                foreach (Agent agent in currentAgents[brainKey])
                {
                    Communicator.AgentInfo ai = AgentInfoConvertor(agentInfo[agent]);
                    unityOutput.AgentInfos[brainKey].Value.Add(ai);
                }

                //TODO :: If the key is present, it will raise an error
                //unityOutput.AgentInfos[brainKey] = listAgentInfo;
                hasSentState[brainKey] = true;

                if (triedSendState.Values.All(x => x))
                {
                    if (hasSentState.Values.Any(x => x) || academyDone)
                    {
                        //Debug.Log("Received the new input");
                        var input = communicator.SendOuput(unityOutput);

                        if (input == null)
                        {
                            command = Communicator.Command.Quit;
                            return;
                        }

                        command = input.Command;
                        environmentParameters = input.EnvironmentParameters;

                        // TODO : Send the actions of the input to the agents
                        if (input.AgentActions != null)
                        {
                            //Debug.Log(input.AgentActions["Ball3DBrain"].Value.Count);
                            foreach (string k in input.AgentActions.Keys)
                            {
                                if (currentAgents[k].Count() == 0)
                                {
                                    continue;
                                }
                                if (input.AgentActions[k].Value.Count == 0)
                                {
                                    continue;
                                }
                                for (int i = 0; i < currentAgents[k].Count(); i++)
                                {
                                    currentAgents[k][i].UpdateVectorAction(input.AgentActions[k].Value[i].VectorActions.ToArray());
                                    currentAgents[k][i].UpdateMemoriesAction(input.AgentActions[k].Value[i].Memories.ToList());
                                    currentAgents[k][i].UpdateTextAction(input.AgentActions[k].Value[i].TextActions);
                                }
                            }
                        }
                        // TODO : If input is quit, you must return a completion Output

                        foreach (string k in currentAgents.Keys)
                        {
                            hasSentState[k] = false;
                            triedSendState[k] = false;
                        }
                    }
                }

            }
        }
    }
}



