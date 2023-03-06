CREATE TABLE [dbo].[Employee](  
   [Id] [int] IDENTITY(1,1) NOT NULL,  
   [EmpCode] [varchar](100) NULL,
   [EmpFullName] [varchar](150) NULL,
   [Role] [varchar](150) NULL,
   CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED  
   (  
   [Id] ASC  
   )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,    ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]