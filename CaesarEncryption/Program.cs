using CaesarEncryption;

IEncryption encryption = new CaesarAlgorithm();
IUserConsoleInteraction userConsoleInteraction = new UserConsoleInteraction();
App app = new App(encryption, userConsoleInteraction);
app.Run();