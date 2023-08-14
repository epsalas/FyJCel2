const { exec } = require('child_process');

// Ruta al archivo Startup.cs
const startupPath = '/Startup.cs';  // Cambia esto a la ruta correcta

// Comando para ejecutar el archivo Startup.cs usando dotnet
const dotnetCommand = `dotnet run ${startupPath}`;

// Ejecutar el comando
exec(dotnetCommand, (error, stdout, stderr) => {
  if (error) {
    console.error(`Error al ejecutar dotnet: ${error}`);
    return;
  }
  
  console.log(`Salida de dotnet:\n${stdout}`);
});