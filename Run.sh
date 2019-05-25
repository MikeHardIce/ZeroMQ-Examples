
echo "Start Server"
xterm -hold -e "dotnet run -p ./ZeroServer/ZeroServer.csproj" &

echo "Start Clients"
xterm -hold -e "dotnet run -p ./ZeroClient/ZeroClient.csproj 100" &


xterm -hold -e "dotnet run -p ./ZeroClient/ZeroClient.csproj 22" &

xterm -hold -e "dotnet run -p ./ZeroClient/ZeroClient.csproj 30" &


xterm -hold -e "dotnet run -p ./ZeroClient/ZeroClient.csproj 42" &