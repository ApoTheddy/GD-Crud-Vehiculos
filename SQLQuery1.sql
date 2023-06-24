IF DB_ID('concesionario') IS NOT NULL
	DROP DATABASE concesionario;


CREATE DATABASE concesionario;

USE concesionario;

IF OBJECT_ID('vehicle') IS NOT NULL
	DROP TABLE vehicle;

CREATE TABLE vehicle(
	id_vehicle		INT IDENTITY(1,1) NOT NULL,
	plate			VARCHAR(10),
	model			VARCHAR(20),
	mark			VARCHAR(20),
	color			VARCHAR(20)
);

INSERT INTO vehicle VALUES('vArT4k74sL', 'Chevrolet', 'DB9', 'Verde');
INSERT INTO vehicle VALUES('wK36Qo2hWY', 'BMW', '124 Spider', 'Morado');
INSERT INTO vehicle VALUES('cVutGtRR6g', 'Alfa Romeo', 'GiuLa', 'Morado');
INSERT INTO vehicle VALUES('iTtjBkZm5k', 'Abarth', 'GiuLa', 'Azul');
INSERT INTO vehicle VALUES('JNp5z4f7bI', 'BYD', 'Vantage V12', 'Verde');
INSERT INTO vehicle VALUES('fO3soC4bho', 'Alfa Romeo', '500', 'Verde');
INSERT INTO vehicle VALUES('mJDWLZacOY', 'Bentley', 'DB9', 'Azul');
INSERT INTO vehicle VALUES('G5MR3CwgWL', 'Aston Martin', '4C', 'Rojo');
INSERT INTO vehicle VALUES('k6yfmICrPQ', 'Audi', 'Vantage V12', 'Rojo');
INSERT INTO vehicle VALUES('IWcO2dj509', 'BMW', 'Rapide', 'Morado');
INSERT INTO vehicle VALUES('pMw9V7i6Ra', 'BYD', 'Rapide', 'Verde');
INSERT INTO vehicle VALUES('dIbgCp7QQn', 'Citroen', 'GiuLa', 'Azul');
INSERT INTO vehicle VALUES('jly8bTRShH', 'Aston Martin', '500', 'Rojo');
INSERT INTO vehicle VALUES('cOnK4y0uMo', 'BMW', '4C', 'Rojo');
INSERT INTO vehicle VALUES('jd4r3cg8oJ', 'Chevrolet', 'DB9', 'Morado');
INSERT INTO vehicle VALUES('NytkEEcLqP', 'Dacia', 'MiTo', 'Rojo');
INSERT INTO vehicle VALUES('CZc5JB9cEm', 'Chevrolet', '124 Spider', 'Rojo');
INSERT INTO vehicle VALUES('vpIzyyzklC', 'Citroen', '4C', 'Rojo');
INSERT INTO vehicle VALUES('Ao46O35qd2', 'DFSK', 'Vantage V12', 'Rojo');
INSERT INTO vehicle VALUES('RDlAeq4Myb', 'Audi', 'Stelvio', 'Morado');
INSERT INTO vehicle VALUES('9LGU5yNpK0', 'Aston Martin', '500', 'Negro');
INSERT INTO vehicle VALUES('lsbBQqVm47', 'Dacia', '4C', 'Morado');
INSERT INTO vehicle VALUES('4h19oJjszK', 'Aston Martin', 'Stelvio', 'Rojo');
INSERT INTO vehicle VALUES('Qe94wycLF6', 'Bentley', 'Giulietta', 'Morado');
INSERT INTO vehicle VALUES('IM3KmdHYjM', 'BMW', 'DB9', 'Morado');
INSERT INTO vehicle VALUES('VEPRiOAumM', 'Alfa Romeo', 'MiTo', 'Negro');
INSERT INTO vehicle VALUES('9SYVH4DiNa', 'Aston Martin', 'MiTo', 'Azul');
INSERT INTO vehicle VALUES('GnWOT6rXg4', 'Chevrolet', '124 Spider', 'Rojo');
INSERT INTO vehicle VALUES('ZoayLUF5mh', 'BMW', '124 Spider', 'Morado');
INSERT INTO vehicle VALUES('l5doVBDlm2', 'BMW', 'Giulietta', 'Negro');
INSERT INTO vehicle VALUES('e0xU9kEkcX', 'BMW', 'Giulietta', 'Rojo');
INSERT INTO vehicle VALUES('uuzbwCgfcb', 'Citroen', '500', 'Morado');
INSERT INTO vehicle VALUES('NTqhNkjJeW', 'BYD', '500', 'Morado');
INSERT INTO vehicle VALUES('HHFpYvmcnG', 'BMW', '124 Spider', 'Verde');
INSERT INTO vehicle VALUES('Kpcmr554tk', 'Abarth', 'DB9', 'Rojo');
INSERT INTO vehicle VALUES('2euJcH6pCt', 'Citroen', '500', 'Verde');
INSERT INTO vehicle VALUES('Ag930oKflj', 'BYD', 'GiuLa', 'Morado');
INSERT INTO vehicle VALUES('xuebAis6tc', 'Audi', 'DB9', 'Rojo');
INSERT INTO vehicle VALUES('JxK8V3k5ZS', 'Aston Martin', 'Stelvio', 'Rojo');
INSERT INTO vehicle VALUES('HhOftfHfgF', 'Bentley', 'MiTo', 'Azul');
INSERT INTO vehicle VALUES('3GrNudpiC9', 'Audi', '4C', 'Morado');
INSERT INTO vehicle VALUES('WeXxt55Ekm', 'Bentley', '124 Spider', 'Azul');
INSERT INTO vehicle VALUES('HZRb01vN1K', 'Chevrolet', 'GiuLa', 'Morado');
INSERT INTO vehicle VALUES('BkSp3zPbPU', 'Chevrolet', 'GiuLa', 'Rojo');
INSERT INTO vehicle VALUES('7ukGTPMnHy', 'Dacia', 'DB9', 'Negro');
INSERT INTO vehicle VALUES('9fbpML5dVi', 'Dacia', 'MiTo', 'Morado');
INSERT INTO vehicle VALUES('fuBnOvBO8k', 'Aston Martin', 'GiuLa', 'Rojo');
INSERT INTO vehicle VALUES('3PM9TWHngt', 'DFSK', '4C', 'Rojo');
INSERT INTO vehicle VALUES('yhdmtpIOSM', 'DFSK', '4C', 'Morado');
INSERT INTO vehicle VALUES('YQ01Cpx5TJ', 'Abarth', '124 Spider', 'Verde');
INSERT INTO vehicle VALUES('mYn9ZuyU75', 'Ferrari', 'MiTo', 'Azul');
INSERT INTO vehicle VALUES('xbIXrvQoE6', 'Citroen', '4C', 'Morado');
INSERT INTO vehicle VALUES('17CYKQbyVV', 'DFSK', 'Giulietta', 'Negro');
INSERT INTO vehicle VALUES('uRG7dhUuFm', 'Audi', '4C', 'Negro');
INSERT INTO vehicle VALUES('PxjP8CFzsW', 'Chevrolet', '4C', 'Negro');
INSERT INTO vehicle VALUES('RybllPb3jT', 'BYD', 'DB9', 'Rojo');
INSERT INTO vehicle VALUES('fN5B7a1Qa1', 'Citroen', 'MiTo', 'Azul');
INSERT INTO vehicle VALUES('FxCJtRR2e0', 'BMW', 'DB9', 'Morado');
INSERT INTO vehicle VALUES('L4An9PVBbd', 'Ferrari', '124 Spider', 'Rojo');
INSERT INTO vehicle VALUES('VKZrZy55og', 'Bentley', 'DB9', 'Morado');
INSERT INTO vehicle VALUES('FLubgzqOmR', 'Chevrolet', 'Stelvio', 'Morado');
INSERT INTO vehicle VALUES('am18dGnuxt', 'Chevrolet', '500', 'Verde');
INSERT INTO vehicle VALUES('YKPOoplb2R', 'Abarth', 'Giulietta', 'Rojo');
INSERT INTO vehicle VALUES('0kaL30lKmW', 'Dacia', '4C', 'Rojo');
INSERT INTO vehicle VALUES('H4xXQoBkHi', 'Alfa Romeo', '500c', 'Verde');
INSERT INTO vehicle VALUES('MNPNWSUBgX', 'Dacia', 'DB9', 'Morado');
INSERT INTO vehicle VALUES('G1qLYBVeVJ', 'Aston Martin', '4C', 'Negro');
INSERT INTO vehicle VALUES('BZGIdSafy5', 'BYD', '4C', 'Morado');
INSERT INTO vehicle VALUES('UP3cCqoxp5', 'Aston Martin', '124 Spider', 'Azul');
INSERT INTO vehicle VALUES('GYUn1Jw4IF', 'Aston Martin', 'Giulietta', 'Verde');
INSERT INTO vehicle VALUES('KHR2fZ2i9I', 'Bentley', 'Rapide', 'Morado');
INSERT INTO vehicle VALUES('RB5vHKucxg', 'Bentley', 'Stelvio', 'Azul');
INSERT INTO vehicle VALUES('HxmyTQq3LX', 'DFSK', 'Vantage V12', 'Rojo');
INSERT INTO vehicle VALUES('qwDP2HnM35', 'DFSK', 'Stelvio', 'Morado');
INSERT INTO vehicle VALUES('jXpFEPthWh', 'BYD', '124 Spider', 'Morado');
INSERT INTO vehicle VALUES('2XLR6eicLY', 'DFSK', 'Giulietta', 'Verde');
INSERT INTO vehicle VALUES('EJGzqARDaL', 'Citroen', '500', 'Verde');
INSERT INTO vehicle VALUES('ANPS9FCSsq', 'Citroen', 'Vantage V12', 'Negro');
INSERT INTO vehicle VALUES('UYYHFuMO2Y', 'Bentley', 'Stelvio', 'Azul');
INSERT INTO vehicle VALUES('H69QwwvkXM', 'Audi', '124 Spider', 'Morado');
INSERT INTO vehicle VALUES('LM5MYl2Vm0', 'Alfa Romeo', 'Giulietta', 'Rojo');
INSERT INTO vehicle VALUES('B89JZ7wBFr', 'Dacia', '500c', 'Verde');
INSERT INTO vehicle VALUES('rGqm5iLKLG', 'Alfa Romeo', 'MiTo', 'Verde');
INSERT INTO vehicle VALUES('ayOaNZGVwz', 'Audi', '124 Spider', 'Morado');
INSERT INTO vehicle VALUES('9ZnO3aRUrz', 'DFSK', 'Giulietta', 'Rojo');
INSERT INTO vehicle VALUES('PBVG1H7jLM', 'Aston Martin', 'DB9', 'Negro');
INSERT INTO vehicle VALUES('gTwVDmS2Ai', 'Chevrolet', 'GiuLa', 'Rojo');
INSERT INTO vehicle VALUES('nX9Dx7Vfay', 'Audi', '4C', 'Azul');
INSERT INTO vehicle VALUES('qQJBxstuJE', 'Bentley', 'Giulietta', 'Morado');
INSERT INTO vehicle VALUES('5vUHFaJj1b', 'Bentley', '124 Spider', 'Verde');
INSERT INTO vehicle VALUES('tjzX4x2RmD', 'Chevrolet', 'DB9', 'Morado');
INSERT INTO vehicle VALUES('nthjZjU3AE', 'Ferrari', 'GiuLa', 'Verde');
INSERT INTO vehicle VALUES('zietyziUyw', 'BMW', '4C', 'Morado');
INSERT INTO vehicle VALUES('OBHAIi3Iww', 'BMW', 'Vantage V12', 'Negro');
INSERT INTO vehicle VALUES('k07RMN4JB3', 'DFSK', 'Giulietta', 'Verde');
INSERT INTO vehicle VALUES('qknT3GQmdh', 'Dacia', 'Rapide', 'Morado');
INSERT INTO vehicle VALUES('h3Nf9HcBTV', 'Abarth', '124 Spider', 'Verde');
INSERT INTO vehicle VALUES('w2rVWZ0A9W', 'DFSK', 'MiTo', 'Morado');
INSERT INTO vehicle VALUES('xX21OlKxDD', 'BYD', '500c', 'Rojo');
INSERT INTO vehicle VALUES('bPD2vVK09k', 'Citroen', 'GiuLa', 'Verde');

SELECT * FROM vehicle;



