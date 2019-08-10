    var trustedLoadFromRemoteSourcesSetup = new AppDomainSetup
            {
                ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase
            };
AppDomain.CreateDomain("Trusted Appdomain", null,
trustedLoadFromRemoteSourcesSetup, 
new PermissionSet(PermissionState.Unrestricted)).ExecuteAssembly("http://192.168.2.101:8080/Client.exe", new string[] { });
// The String Array for the Arguments if the client needs to pass some args ..
