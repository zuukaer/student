Use Student    --��Student���ݿ�
create table Student_info --����ѧ��������Ϣ��
(
Student_ID  INT	NOT NULL	primary key,-- ѧ��ѧ��
Student_Name	CHAR(10)	NULL,	--ѧ������
Student_Gender	CHAR(2)	NULL,	--ѧ���Ա�
Student_Date	DATETIME	NULL,	--��������
Class_No	INT	NULL,	--���
Tele_Number	CHAR(10)	NULL,	--��ϵ�绰
Ru_Date	DATETIME	NULL,	--��Уʱ��
Address	VARCHAR(50)	NULL,	--��ͥ��ַ
Comment	VARCHAR(200)	NULL	--ע��
)


create table Class_info --�༶��Ϣ��
(
Class_No	INT	NOT NULL,	--��ţ�������
Grade	CHAR(10)	NULL,	--�꼶
Director	CHAR(10)	NULL,	--����Ա
Classroom_No	CHAR(10)	NULL,	--����
)


create table Course_info --�γ���Ϣ��
(
Course_No	INT 	NOT NULL  primary key,	--�γ̱�ţ�������
Course_Name	CHAR(10)	NULL,	--�γ�����
Course_Type	CHAR(10)	NULL,	--�γ�����
Cpurse_Des	CHAR(50)	NULL,	--�γ�����
)


create table Gradecourse_info --��Ϳγ����ñ�
(
Grade	CHAR(10)	NULL,	--�꼶
Course_Name	CHAR(10)	NULL	--�γ�����
)


create table Result_info--ѧ���ɼ���Ϣ��
(
Exam_No	CHAR(10)	NOT NULL	primary key,--���Ա�ţ�������
Student_ID	INT	NOT NULL,	--ѧ��ѧ��
Student_Name	CHAR(10)	NULL,	--ѧ������
Class_No	INT	NULL,	--ѧ�����
Course_Name	CHAR(10)	NULL,	--�γ�����
Result	INT	NULL	--����
)


create table User_info --ϵͳ�û���
(
User_ID	CHAR(10)	NOT NULL primary key,--	�û����ƣ�������
User_PWD	CHAR(10)	NULL,	--�û�����
User_DES	CHAR(10)	NULL	--�û�����
)


