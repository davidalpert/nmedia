using System;
using SharpTestsEx;
using MbUnit.Framework;
using MavenThought.MediaLibrary.Core;

namespace MavenThought.MediaLibrary.Core.Tests
{
    [TestFixture]
    public class AppConfigHelperTests
    {
        [Test]
        public void can_resolve_abstract_config_key_name_to_machine_specific_config_key_name()
        {
            string STR_ExpectedFormatString = "{1}-{0}";
            string expectedKeyName = String.Format(STR_ExpectedFormatString, Environment.MachineName, "TestConnection");

            "TestConnection".ToMachineSpecificConfigKey().Should().Be.EqualTo(expectedKeyName);
        }

        [Test]
        public void resolving_a_nonexistant_connection_string_throws()
        {
            var expectedConnectionStringName = "nonexistantConnectionString".ToMachineSpecificConfigKey();
            var expectedErrorMessage = String.Format(AppConfigHelpers.STR_CannotFindConnectionFormatString, expectedConnectionStringName);

            var ex = Assert.Throws<InvalidOperationException>(() =>
            {
                "nonexistantConnectionString".ToMachineSpecificConnectionString();
            });

            ex.Message.Should().Be.EqualTo(expectedErrorMessage);
        }
    }
}
