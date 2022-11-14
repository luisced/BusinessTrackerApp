SET NAMES utf8;

SET time_zone = '+00:00';

SET foreign_key_checks = 0;

SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

set character_set_client = 'utf8';

set character_set_connection = 'utf8';

set character_set_database = 'utf8';

set character_set_results = 'utf8';

set character_set_server = 'utf8';

DROP TABLE IF EXISTS `Comida`;

CREATE TABLE
    `Comida` (
        `NameId` int(11) NOT NULL AUTO_INCREMENT,
        `Name` text NOT NULL,
        `Icon` text NOT NULL,
        `Type` text NOT NULL,
        PRIMARY KEY (`NameId`)
    ) ENGINE = InnoDB DEFAULT CHARSET = latin1;