select * from TestCases

delete from TestCases where tsid=11 AND TCID=2

exec FixTCIDNumber 1, 11

exec FixTestCaseIndetity