-- =============================================
-- PRUEBA PARCIAL: PROGRAMACIÓN I
-- Base de datos: ParcialProgramacion1
-- Sistema de control de productos
-- =============================================

-- 1. Crear la base de datos
IF DB_ID('ParcialProgramacion1') IS NULL
BEGIN
    CREATE DATABASE ParcialProgramacion1;
END;
GO

USE ParcialProgramacion1;
GO

-- 2. Crear la tabla Productos
IF OBJECT_ID('dbo.Productos', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Productos
    (
        IdProducto INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL,
        Categoria NVARCHAR(50) NOT NULL,
        Precio DECIMAL(10,2) NOT NULL CHECK (Precio > 0),
        Existencias INT NOT NULL CHECK (Existencias >= 0)
    );
END;
GO

-- 3. Registrar al menos tres productos de ejemplo
INSERT INTO dbo.Productos (Nombre, Categoria, Precio, Existencias) VALUES
('Mouse inalámbrico', 'Accesorios', 12.50, 40),
('Teclado mecánico', 'Accesorios', 35.00, 15),
('Monitor 24 pulgadas', 'Pantallas', 129.99, 8);
GO

-- 4. Verificar
SELECT * FROM dbo.Productos;
GO