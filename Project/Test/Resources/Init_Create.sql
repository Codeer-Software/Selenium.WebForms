CREATE TABLE [dbo].[Table_Data](
	[Id] [int] NOT NULL,
	[Label] [text] NULL,
	[TextBox] [text] NULL,
	[Button] [text] NULL,
	[LinkButton] [text] NULL,
	[CheckBox] [bit] NOT NULL,
	[RadioButton] [bit] NULL,
 CONSTRAINT [PK_Table_Data] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]