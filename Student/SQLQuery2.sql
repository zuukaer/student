Use Student    --打开Student数据库
create table Student_info --创建学生基本信息表
(
Student_ID  INT	NOT NULL	primary key,-- 学生学号
Student_Name	CHAR(10)	NULL,	--学生姓名
Student_Gender	CHAR(2)	NULL,	--学生性别
Student_Date	DATETIME	NULL,	--出生日期
Class_No	INT	NULL,	--班号
Tele_Number	CHAR(10)	NULL,	--联系电话
Ru_Date	DATETIME	NULL,	--入校时间
Address	VARCHAR(50)	NULL,	--家庭地址
Comment	VARCHAR(200)	NULL	--注释
)


create table Class_info --班级信息表
(
Class_No	INT	NOT NULL,	--班号（主键）
Grade	CHAR(10)	NULL,	--年级
Director	CHAR(10)	NULL,	--辅导员
Classroom_No	CHAR(10)	NULL,	--教室
)


create table Course_info --课程信息表
(
Course_No	INT 	NOT NULL  primary key,	--课程编号（主键）
Course_Name	CHAR(10)	NULL,	--课程名称
Course_Type	CHAR(10)	NULL,	--课程类型
Cpurse_Des	CHAR(50)	NULL,	--课程描述
)


create table Gradecourse_info --年纪课程设置表
(
Grade	CHAR(10)	NULL,	--年级
Course_Name	CHAR(10)	NULL	--课程名称
)


create table Result_info--学生成绩信息表
(
Exam_No	CHAR(10)	NOT NULL	primary key,--考试编号（主键）
Student_ID	INT	NOT NULL,	--学生学号
Student_Name	CHAR(10)	NULL,	--学生姓名
Class_No	INT	NULL,	--学生班号
Course_Name	CHAR(10)	NULL,	--课程名称
Result	INT	NULL	--分数
)


create table User_info --系统用户表
(
User_ID	CHAR(10)	NOT NULL primary key,--	用户名称（主键）
User_PWD	CHAR(10)	NULL,	--用户密码
User_DES	CHAR(10)	NULL	--用户描述
)


