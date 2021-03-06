CREATE TABLE IF NOT EXISTS `TRAN_POST_VOTE` (
    `POST_VOTE_ID` INT(11) NOT NULL AUTO_INCREMENT,
    `VOTE_ID` INT(11) NULL,
	`VOTE_VALUE` VARCHAR(50) NULL,	
	`USER_ID` INT(11) NULL,
	`SUBSYSTEM_ID` INT(11) NULL,
	`SUBSYSTEM_VALUE` VARCHAR(50) NULL,
	`SUBSYSTEM_REFERENCE_ID` INT(11) NULL,
    `CREATED_BY` INT(11) DEFAULT NULL,
	`CREATED_DATE` DATETIME DEFAULT NULL,
    `MODIFIED_BY` INT(11) DEFAULT NULL,
	`MODIFIED_DATE` DATETIME DEFAULT NULL,
    `UPDATE_SEQ` INT(11) DEFAULT NULL,
    PRIMARY KEY (`POST_VOTE_ID`)
)  ENGINE=InnoDB DEFAULT CHARSET=latin1;
