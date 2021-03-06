﻿using System;
using SPMeta2.Containers.Services.Base;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Base;
using SPMeta2.Enumerations;

namespace SPMeta2.Containers.DefinitionGenerators
{
    public class WelcomePageDefinitionGenerator : TypedDefinitionGeneratorServiceBase<WelcomePageDefinition>
    {
        #region properties


        #endregion

        public override DefinitionBase GenerateRandomDefinition(Action<DefinitionBase> action)
        {
            return WithEmptyDefinition(def =>
            {
                // TODO
                // generate list with the random page and  setup and welcome page

                def.Url = "Shared Documents";
            });
        }
    }
}
