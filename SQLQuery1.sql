select * from TestCases

UPDATE TestCases
 SET 
 TestObjective = 'A',
 Preconditions = 'B',
 Actions= 'C', 
 Expec_res = 'D', 
 Exec_type = 1, 
 Importance = 2
 WHERE TestCaseID = 1 AND TSID = 24