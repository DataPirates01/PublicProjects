ALTER TABLE TRAN_POST_VOTES MODIFY `UPDATE_SEQ` int(11) AFTER SUBSYSTEM_VALUE;
ALTER TABLE TRAN_POST_VOTES MODIFY `MODIFIED_DATE` datetime AFTER SUBSYSTEM_VALUE;
ALTER TABLE TRAN_POST_VOTES MODIFY `MODIFIED_BY` int(11) AFTER SUBSYSTEM_VALUE;
ALTER TABLE TRAN_POST_VOTES MODIFY `CREATED_DATE` datetime AFTER SUBSYSTEM_VALUE;
ALTER TABLE TRAN_POST_VOTES MODIFY `CREATED_BY` int(11) AFTER SUBSYSTEM_VALUE;
ALTER TABLE TRAN_POST_VOTES MODIFY `SUBSYSTEM_REFERENCE_ID` int(11) AFTER SUBSYSTEM_VALUE;
ALTER TABLE TRAN_POST_VOTES MODIFY `SUBSYSTEM_ID` int(11) AFTER SUBSYSTEM_VALUE;
ALTER TABLE TRAN_POST_VOTES MODIFY `SUBSYSTEM_VALUE` varchar(255) AFTER SUBSYSTEM_ID;

