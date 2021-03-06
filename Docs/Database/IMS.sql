/****** Object:  Table [dbo].[DM_EMPLOYER]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_EMPLOYER](
	[ID] [int] NOT NULL,
	[EMPLOYER_NAME] [nvarchar](50) NULL,
	[EMPLOYER_SEX] [nvarchar](50) NULL,
	[BIRTHDAY] [date] NULL,
	[TINH_LOCATION_ID] [int] NULL,
	[TINH_LOCATION_NAME] [nvarchar](50) NULL,
	[HUYEN_LOCATION_ID] [int] NULL,
	[HUYEN_LOCATION_NAME] [nvarchar](50) NULL,
	[XA_LOCATION_ID] [int] NULL,
	[XA_LOCATION_NAME] [nvarchar](50) NULL,
	[RANK_ID] [int] NULL,
	[TITLE_ID] [int] NULL,
	[ORGANIZATION_ID] [int] NULL,
	[PHONE1] [nvarchar](50) NULL,
	[PHONE2] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[AVATAR] [nvarchar](50) NULL,
 CONSTRAINT [PK_DM_EMPLOYER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_LOCATION]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_LOCATION](
	[ID] [int] NOT NULL,
	[LOCATION_NAME] [nvarchar](50) NULL,
	[LOCATION_ORDER] [int] NULL,
	[LOCATION_PARENT_ID] [int] NULL,
	[LOCATION_LEVEL] [int] NULL,
 CONSTRAINT [PK_DM_LOCATION] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_ORGANIZATION]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_ORGANIZATION](
	[ID] [int] NOT NULL,
	[ORGANIZATION_NAME] [nvarchar](50) NULL,
	[ORGANIZATION_DESCRIPTION] [nvarchar](50) NULL,
	[SPECIAL_ID] [int] NULL,
	[ORGANIZATION_LEVEL] [int] NULL,
 CONSTRAINT [PK_DM_ORGANIZATION] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_ORIGIN]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_ORIGIN](
	[ID] [int] NOT NULL,
	[ORIGIN_NAME] [nvarchar](50) NULL,
	[ORIGIN_DESCRIPTION] [nvarchar](50) NULL,
 CONSTRAINT [PK_DM_ORIGIN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_OUTPUTTYPE]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_OUTPUTTYPE](
	[ID] [int] NOT NULL,
	[OUTPUTTYPE_NAME] [nvarchar](50) NULL,
	[ISUSED] [bit] NULL,
 CONSTRAINT [PK_DM_OUTPUTTYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_PARAMETER]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_PARAMETER](
	[ID] [int] NOT NULL,
	[PARAMETER_NAME] [nvarchar](50) NULL,
	[PARAMETER_VALUE] [nvarchar](50) NULL,
 CONSTRAINT [PK_DM_PARAMETER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_PRICE]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_PRICE](
	[ID] [int] NOT NULL,
	[PRICE_NAME] [nvarchar](50) NULL,
	[PRICE_SYMBOL] [nvarchar](50) NULL,
	[PRICE_CODE] [nvarchar](50) NULL,
	[PRICE_MIN_VALUE] [float] NULL,
	[IS_DEFAULT] [bit] NULL,
 CONSTRAINT [PK_DM_PRICE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_PRODUCTCATEGORY]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_PRODUCTCATEGORY](
	[ID] [int] NOT NULL,
	[PRODUCTCATEGORY_NAME] [nvarchar](50) NULL,
	[PRODUCTCATEGORY_DESCRIPTION] [nvarchar](50) NULL,
 CONSTRAINT [PK_DM_PRODUCTCATEGORY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_PRODUCTS]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_PRODUCTS](
	[ID] [int] NOT NULL,
	[PRODUCTS_NAME] [nvarchar](50) NULL,
	[PRODUCTS_NAME_OTHER] [nvarchar](50) NULL,
	[PRODUCTS_CODE] [nvarchar](50) NULL,
	[PRODUCTS_DESCRIPTION] [nvarchar](50) NULL,
	[PRODUCTS_SHORT_DESCRIPTION] [nvarchar](50) NULL,
	[ORIGIN_ID] [int] NULL,
	[ORIGIN_NAME] [nvarchar](50) NULL,
	[UNIT_ID] [int] NULL,
	[UNIT_NAME] [nvarchar](50) NULL,
	[SUPPLIER_ID] [int] NULL,
	[SUPPLIER_NAME] [nvarchar](50) NULL,
	[PRICE_ID] [int] NULL,
	[PRICE_NAME] [nvarchar](50) NULL,
	[PRODUCTCATEGORY_ID] [int] NULL,
	[PRODUCTCATEGORY_NAME] [nvarchar](50) NULL,
	[PRICE_DEFAULT] [bit] NULL,
 CONSTRAINT [PK_DM_PRODUCTS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_RANK]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_RANK](
	[ID] [int] NOT NULL,
	[RANK_NAME] [nvarchar](50) NULL,
	[RANK_DESCRIPTION] [nvarchar](50) NULL,
 CONSTRAINT [PK_DM_RANK] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_SPECIAL]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_SPECIAL](
	[ID] [int] NOT NULL,
	[SPECIAL_NAME] [nvarchar](50) NULL,
	[SPECIAL_DESCRIPTION] [nvarchar](50) NULL,
 CONSTRAINT [PK_DM_SPECIAL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_SUPPLIER]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_SUPPLIER](
	[ID] [int] NOT NULL,
	[SUPPLIER_NAME] [nvarchar](50) NULL,
	[SUPPLIER_DESCRIPTION] [nvarchar](50) NULL,
	[PARENT_ID] [int] NULL,
 CONSTRAINT [PK_DM_SUPPLIER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_TITLE]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_TITLE](
	[ID] [int] NOT NULL,
	[TITLE_NAME] [nvarchar](50) NULL,
	[TITLE_DESCRIPTION] [nvarchar](50) NULL,
 CONSTRAINT [PK_DM_TITLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_UNIT]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_UNIT](
	[ID] [int] NOT NULL,
	[UNIT_NAME] [nvarchar](50) NULL,
	[UNIT_SHORT_NAME] [nvarchar](50) NULL,
	[UNIT_DESCRIPTION] [nvarchar](50) NULL,
 CONSTRAINT [PK_DM_UNIT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DM_WAREHOUSE]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_WAREHOUSE](
	[ID] [int] NOT NULL,
	[WAREHOUSE_NAME] [nvarchar](50) NULL,
	[PARENT_ID] [int] NULL,
	[WAREHOUSE_DESCRIPTION] [nvarchar](50) NULL,
 CONSTRAINT [PK_DM_WAREHOUSE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DT_FUNDS]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DT_FUNDS](
	[ID] [int] NOT NULL,
	[FUNDS_NAME] [nvarchar](50) NULL,
	[FUNDS_DESCRIPTION] [nvarchar](50) NULL,
	[FUNDS_VALUE] [float] NULL,
 CONSTRAINT [PK_DT_FUNDS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DT_INPUT]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DT_INPUT](
	[ID] [int] NOT NULL,
	[INPUT_NAME] [nvarchar](50) NULL,
	[INPUT_CODE] [nvarchar](50) NULL,
	[WAREHOUSE_ID] [int] NULL,
	[WAREHOUSE_NAME] [nvarchar](50) NULL,
	[ORGANIZATION_ID] [int] NULL,
	[ORGANIZATION_NAME] [nvarchar](50) NULL,
	[EXPIRED_DATE] [date] NULL,
	[IS_ASSET] [bit] NULL,
	[USER_ID] [int] NULL,
	[USER_NAME] [nvarchar](50) NULL,
	[IDNUMBER] [int] NULL,
	[IDBOOK] [int] NULL,
	[CAUSE_DESCRIPTION] [nvarchar](50) NULL,
	[FUNDS_ID] [int] NULL,
	[FUNDS_NAME] [nvarchar](50) NULL,
	[TOTAL_VALUE] [float] NULL,
 CONSTRAINT [PK_DT_INPUT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DT_INPUTDETAIL]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DT_INPUTDETAIL](
	[ID] [int] NOT NULL,
	[INPUT_ID] [int] NULL,
	[PRODUCT_ID] [int] NULL,
	[PRODUCT_NAME] [nvarchar](50) NULL,
	[PRODUCT_OTHER_NAME] [nvarchar](50) NULL,
	[PRODUCT_CODE] [nvarchar](50) NULL,
	[PRODUCTS_DESCRIPTION] [nvarchar](50) NULL,
	[PRODUCTS_SHORT_DESCRIPTION] [nvarchar](50) NULL,
	[ORIGIN_ID] [int] NULL,
	[ORIGIN_NAME] [nvarchar](50) NULL,
	[UNIT_ID] [int] NULL,
	[UNIT_NAME] [nvarchar](50) NULL,
	[SUPPLIER_ID] [int] NULL,
	[SUPPLIER_NAME] [nvarchar](50) NULL,
	[PRICE_ID] [int] NULL,
	[PRICE_NAME] [nvarchar](50) NULL,
	[PRODUCTCATEGORY_ID] [int] NULL,
	[PRODUCTCATEGORY_NAME] [nvarchar](50) NULL,
	[PRICE_DEFAULT] [float] NULL,
	[INPUT_PRICE] [float] NULL,
	[QUANTITY] [float] NULL,
	[WAREHOUSE_ID] [int] NULL,
	[PRODUCT_STATUS] [nvarchar](50) NULL,
	[IS_BUY] [bit] NULL,
	[TOTAL] [float] NULL,
 CONSTRAINT [PK_DT_INPUTDETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DT_OUTPUT]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DT_OUTPUT](
	[ID] [int] NOT NULL,
	[OUTPUT_NAME] [nvarchar](50) NULL,
	[OUTPUT_CODE] [nvarchar](50) NULL,
	[WAREHOUSE_ID] [int] NULL,
	[WAREHOUSE_NAME] [nvarchar](50) NULL,
	[ORGANIZATION_ID] [int] NULL,
	[ORGANIZATION_NAME] [nvarchar](50) NULL,
	[EXPIRED_DATE] [date] NULL,
	[IS_ASSET] [bit] NULL,
	[USER_ID] [int] NULL,
	[USER_NAME] [nvarchar](50) NULL,
	[IDNUMBER] [int] NULL,
	[IDBOOK] [int] NULL,
	[CAUSE_DESCRIPTION] [nvarchar](50) NULL,
	[FUNDS_ID] [int] NULL,
	[FUNDS_NAME] [nvarchar](50) NULL,
	[TOTAL_VALUE] [float] NULL,
	[OUTPUT_TYPE] [int] NULL,
	[OUTPUT_TYPE_NAME] [nvarchar](50) NULL,
 CONSTRAINT [PK_DT_OUTPUT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DT_OUTPUTDETAIL]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DT_OUTPUTDETAIL](
	[ID] [int] NOT NULL,
	[OUTPUT_ID] [int] NULL,
	[PRODUCT_ID] [int] NULL,
	[PRODUCT_NAME] [nvarchar](50) NULL,
	[PRODUCT_OTHER_NAME] [nvarchar](50) NULL,
	[PRODUCT_CODE] [nvarchar](50) NULL,
	[PRODUCTS_DESCRIPTION] [nvarchar](50) NULL,
	[PRODUCTS_SHORT_DESCRIPTION] [nvarchar](50) NULL,
	[ORIGIN_ID] [int] NULL,
	[ORIGIN_NAME] [nvarchar](50) NULL,
	[UNIT_ID] [int] NULL,
	[UNIT_NAME] [nvarchar](50) NULL,
	[SUPPLIER_ID] [int] NULL,
	[SUPPLIER_NAME] [nvarchar](50) NULL,
	[PRICE_ID] [int] NULL,
	[PRICE_NAME] [nvarchar](50) NULL,
	[PRODUCTCATEGORY_ID] [int] NULL,
	[PRODUCTCATEGORY_NAME] [nvarchar](50) NULL,
	[PRICE_DEFAULT] [bit] NULL,
	[OUTPUT_PRICE] [nvarchar](50) NULL,
	[QUANTITY] [float] NULL,
	[WAREHOUSE_ID] [int] NULL,
	[PRODUCT_STATUS] [nvarchar](50) NULL,
	[IS_BUY] [bit] NULL,
	[TOTAL] [float] NULL,
	[OUTPUT_DATE] [date] NULL,
	[RETURN_DATE] [date] NULL,
 CONSTRAINT [PK_DT_OUTPUTDETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DT_PRICEHISTORY]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DT_PRICEHISTORY](
	[ID] [int] NOT NULL,
	[PRODUCT_ID] [int] NULL,
	[PRICE_VALUE] [float] NULL,
	[PRICE_ID] [int] NULL,
 CONSTRAINT [PK_DT_PRICEHISTORY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DT_PRODUCT_PARAMETER]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DT_PRODUCT_PARAMETER](
	[ID] [int] NOT NULL,
	[PRODUCT_ID] [int] NULL,
	[PARAMETER_ID] [int] NULL,
 CONSTRAINT [PK_DT_PRODUCT_PARAMETER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_CONFIG]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_CONFIG](
	[ID] [int] NOT NULL,
	[CONFIG_NAME] [nvarchar](50) NULL,
	[CONFIG_VALUE] [nvarchar](50) NULL,
	[CONFIG_DESCRIPTION] [nvarchar](50) NULL,
 CONSTRAINT [PK_HT_CONFIG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_FORM]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_FORM](
	[ID] [int] NOT NULL,
	[FORM_NAME] [nvarchar](50) NULL,
	[FORM_TITLE] [nvarchar](50) NULL,
	[MENU_NAME] [nvarchar](50) NULL,
	[IS_SHOW_DIALOG] [bit] NULL,
	[SHORTCUT_KEY] [nvarchar](50) NULL,
	[IS_USED] [bit] NULL,
	[FORM_ORDER] [int] NULL,
 CONSTRAINT [PK_HT_FORM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_MASTER_ORGANIZATION]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_MASTER_ORGANIZATION](
	[ID] [int] NOT NULL,
	[EMPLOYER_ID] [int] NULL,
	[ORGANIZATION_ID] [int] NULL,
	[ORGANIZATION_LEVEL] [int] NULL,
 CONSTRAINT [PK_HT_MASTER_ORGANIZATION] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_ROLE]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_ROLE](
	[ID] [int] NOT NULL,
	[ROLE_NAME] [nvarchar](50) NULL,
	[ROLE_DESCRIPTION] [nvarchar](50) NULL,
	[IS_DEFAULT] [bit] NULL,
 CONSTRAINT [PK_HT_ROLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_ROLE_FORM]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_ROLE_FORM](
	[ID] [int] NOT NULL,
	[ROLE_ID] [int] NULL,
	[FORM_ID] [int] NULL,
 CONSTRAINT [PK_HT_ROLE_FORM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_ROLE_USER]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_ROLE_USER](
	[ID] [int] NOT NULL,
	[ROLE_ID] [int] NULL,
	[USER_ID] [int] NULL,
 CONSTRAINT [PK_HT_ROLE_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_SYSTEM_LOG]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_SYSTEM_LOG](
	[ID] [int] NOT NULL,
	[TABLE_NAME] [nvarchar](50) NULL,
	[ROW_NUMBER] [int] NULL,
	[CREATE_AT] [date] NULL,
	[CREATE_BY_USERNAME] [nvarchar](50) NULL,
	[LAST_MODIFIED] [date] NULL,
	[MODIFIED_BY_USERNAME] [nvarchar](50) NULL,
	[DELETE_AT] [date] NULL,
	[DELETE_BY_USERNAME] [nvarchar](50) NULL,
	[REMARKS] [nvarchar](50) NULL,
 CONSTRAINT [PK_HT_SYSTEM_LOG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_TITLE_EMPLOYER]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_TITLE_EMPLOYER](
	[ID] [int] NOT NULL,
	[TITLE_ID] [int] NULL,
	[EMPLOYER_ID] [int] NULL,
 CONSTRAINT [PK_HT_TITLE_EMPLOYER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_USER]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_USER](
	[ID] [int] NOT NULL,
	[USER_NAME] [nvarchar](50) NULL,
	[PASSWORD] [nvarchar](50) NULL,
	[LAST_LOGIN] [date] NULL,
	[IP_LOGIN] [nvarchar](50) NULL,
	[NUMBER_LOGIN] [int] NULL,
	[IS_BLOCKED] [bit] NULL,
	[ROLE_USER_ID] [int] NULL,
 CONSTRAINT [PK_HT_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HT_USER_EMPLOYER]    Script Date: 6/4/2017 4:59:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HT_USER_EMPLOYER](
	[ID] [int] NOT NULL,
	[USER_ID] [int] NULL,
	[EMPLOYER_ID] [int] NULL,
 CONSTRAINT [PK_HT_USER_EMPLOYER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Statistic [PK_DM_EMPLOYER]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_EMPLOYER]([PK_DM_EMPLOYER]) WITH STATS_STREAM = 0x010000000100000000000000000000008864E4560000000040000000000000000000000000000000380300003800000004000A00000000000000000001000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_LOCATION]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_LOCATION]([PK_DM_LOCATION]) WITH STATS_STREAM = 0x010000000100000000000000000000008864E4560000000040000000000000000000000000000000380300003800000004000A00000000000000000001000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_ORGANIZATION]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_ORGANIZATION]([PK_DM_ORGANIZATION]) WITH STATS_STREAM = 0x010000000100000000000000000000008864E4560000000040000000000000000000000000000000380300003800000004000A00000000000000000001000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_ORIGIN]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_ORIGIN]([PK_DM_ORIGIN]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_OUTPUTTYPE]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_OUTPUTTYPE]([PK_DM_OUTPUTTYPE]) WITH STATS_STREAM = 0x010000000100000000000000000000008864E4560000000040000000000000000000000000000000380300003800000004000A00000000000000000001000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_PARAMETER]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_PARAMETER]([PK_DM_PARAMETER]) WITH STATS_STREAM = 0x010000000100000000000000000000008864E4560000000040000000000000000000000000000000380300003800000004000A00000000000000000001000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_PRICE]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_PRICE]([PK_DM_PRICE]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_PRODUCTCATEGORY]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_PRODUCTCATEGORY]([PK_DM_PRODUCTCATEGORY]) WITH STATS_STREAM = 0x01000000010000000000000000000000EB6E7E470000000040000000000000000000000000000000380300003800000004000A00000000000000000061006700, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_PRODUCTS]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_PRODUCTS]([PK_DM_PRODUCTS]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_RANK]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_RANK]([PK_DM_RANK]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_SPECIAL]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_SPECIAL]([PK_DM_SPECIAL]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_SUPPLIER]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_SUPPLIER]([PK_DM_SUPPLIER]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_TITLE]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_TITLE]([PK_DM_TITLE]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_UNIT]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_UNIT]([PK_DM_UNIT]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DM_WAREHOUSE]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DM_WAREHOUSE]([PK_DM_WAREHOUSE]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DT_FUNDS]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DT_FUNDS]([PK_DT_FUNDS]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DT_INPUT]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DT_INPUT]([PK_DT_INPUT]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DT_INPUTDETAIL]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DT_INPUTDETAIL]([PK_DT_INPUTDETAIL]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DT_OUTPUT]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DT_OUTPUT]([PK_DT_OUTPUT]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DT_OUTPUTDETAIL]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DT_OUTPUTDETAIL]([PK_DT_OUTPUTDETAIL]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DT_PRICEHISTORY]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DT_PRICEHISTORY]([PK_DT_PRICEHISTORY]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_DT_PRODUCT_PARAMETER]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[DT_PRODUCT_PARAMETER]([PK_DT_PRODUCT_PARAMETER]) WITH STATS_STREAM = 0x01000000010000000000000000000000EB6E7E470000000040000000000000000000000000000000380300003800000004000A00000000000000000061006700, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_CONFIG]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_CONFIG]([PK_HT_CONFIG]) WITH STATS_STREAM = 0x01000000010000000000000000000000CA3A4794000000004000000000000000000000000000000038031B733800000004000A00000000000000000000000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_FORM]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_FORM]([PK_HT_FORM]) WITH STATS_STREAM = 0x01000000010000000000000000000000CA3A4794000000004000000000000000000000000000000038031B733800000004000A00000000000000000000000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_MASTER_ORGANIZATION]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_MASTER_ORGANIZATION]([PK_HT_MASTER_ORGANIZATION]) WITH STATS_STREAM = 0x01000000010000000000000000000000EB6E7E470000000040000000000000000000000000000000380300003800000004000A00000000000000000061006700, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_ROLE]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_ROLE]([PK_HT_ROLE]) WITH STATS_STREAM = 0x01000000010000000000000000000000CA3A4794000000004000000000000000000000000000000038031B733800000004000A00000000000000000000000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_ROLE_FORM]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_ROLE_FORM]([PK_HT_ROLE_FORM]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_ROLE_USER]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_ROLE_USER]([PK_HT_ROLE_USER]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_SYSTEM_LOG]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_SYSTEM_LOG]([PK_HT_SYSTEM_LOG]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_TITLE_EMPLOYER]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_TITLE_EMPLOYER]([PK_HT_TITLE_EMPLOYER]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_USER]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_USER]([PK_HT_USER]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_HT_USER_EMPLOYER]    Script Date: 6/4/2017 4:59:31 PM ******/
UPDATE STATISTICS [dbo].[HT_USER_EMPLOYER]([PK_HT_USER_EMPLOYER]) WITH STATS_STREAM = 0x01000000010000000000000000000000A3D3C7DB0000000040000000000000000000000000000000380300003800000004000A00000000000000000038000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nếu có lỗi thì log vào đây' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HT_SYSTEM_LOG', @level2type=N'COLUMN',@level2name=N'REMARKS'
GO
