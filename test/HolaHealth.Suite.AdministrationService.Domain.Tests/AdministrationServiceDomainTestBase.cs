﻿using Volo.Abp.Modularity;

namespace HolaHealth.Suite.AdministrationService;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class AdministrationServiceDomainTestBase<TStartupModule> : AdministrationServiceTestBase<TStartupModule>
 where TStartupModule : IAbpModule
{

}
