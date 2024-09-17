CREATE TABLE Usuarios (
    NombreUsuario NVARCHAR(50) PRIMARY KEY,
    Password NVARCHAR(255) NOT NULL, -- Guarda contraseñas en forma de hash
    Email NVARCHAR(255) NOT NULL
);
