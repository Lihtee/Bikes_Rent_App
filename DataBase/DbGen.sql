
CREATE TABLE [ИсторияРасценок] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [ДатаНачала] DATETIME  NOT NULL,

	 [ДатаОкончания] DATETIME  NULL,

	 [Стоимость] DECIMAL  NOT NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 [ТипВелосипеда] UNIQUEIDENTIFIER  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [СостояниеВелосипеда] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [Название] VARCHAR(255)  NOT NULL,

	 [Актуально] BIT  NULL,

	 [ДатаНачалаАктуальности] DATETIME  NULL,

	 [ДатаОкончанияАктуальности] DATETIME  NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [ТипВелосипеда] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [Название] VARCHAR(255)  NOT NULL,

	 [Актуально] BIT  NULL,

	 [ДатаНачалаАктуальности] DATETIME  NULL,

	 [ДатаОкончанияАктуальности] DATETIME  NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [ТочкаПроката] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [Адрес] VARCHAR(255)  NOT NULL,

	 [Актуально] BIT  NULL,

	 [ДатаНачалаАктуальности] DATETIME  NULL,

	 [ДатаОкончанияАктуальности] DATETIME  NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [ВелосипедВПеревозке] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 [Велосипед] UNIQUEIDENTIFIER  NOT NULL,

	 [ПеревозкаВелосипеда] UNIQUEIDENTIFIER  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [ПрокатВелосипеда] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [ДатаНачала] DATETIME  NOT NULL,

	 [ПлановаяДлительность] INT  NOT NULL,

	 [ФактическаяДатаСдачи] DATETIME  NULL,

	 [ПлановаяСтоимость] DECIMAL  NOT NULL,

	 [ФактическаяСтоимость] DECIMAL  NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 [ТочкаВыдачи] UNIQUEIDENTIFIER  NOT NULL,

	 [Клиент] UNIQUEIDENTIFIER  NOT NULL,

	 [ТочкаСдачи] UNIQUEIDENTIFIER  NULL,

	 [Прокатчик_m0] UNIQUEIDENTIFIER  NOT NULL,

	 [Велосипед_m0] UNIQUEIDENTIFIER  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [ПеревозкаВелосипеда] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [Стоимость] DECIMAL  NOT NULL,

	 [ДатаНачала] DATETIME  NOT NULL,

	 [ДатаКонца] DATETIME  NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 [КонечнаяТочка_m0] UNIQUEIDENTIFIER  NOT NULL,

	 [НачальнаяТочка_m0] UNIQUEIDENTIFIER  NOT NULL,

	 [Водитель_m0] UNIQUEIDENTIFIER  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [Сотрудник] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [ФИО] VARCHAR(255)  NOT NULL,

	 [Актуально] BIT  NULL,

	 [ДатаНачалаАктуальности] DATETIME  NULL,

	 [ДатаОкончанияАктуальности] DATETIME  NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [Клиент] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [ФИО] VARCHAR(255)  NOT NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [ИсторияСостояний] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [ДатаНачала] DATETIME  NOT NULL,

	 [ДатаОкончания] DATETIME  NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 [СостояниеВелосипеда] UNIQUEIDENTIFIER  NOT NULL,

	 [Велосипед] UNIQUEIDENTIFIER  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [Велосипед] (

	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,

	 [Номер] INT  NOT NULL,

	 [CreateTime] DATETIME  NULL,

	 [Creator] VARCHAR(255)  NULL,

	 [EditTime] DATETIME  NULL,

	 [Editor] VARCHAR(255)  NULL,

	 [ТочкаПроката] UNIQUEIDENTIFIER  NOT NULL,

	 [ТипВелосипеда] UNIQUEIDENTIFIER  NOT NULL,

	 [ТекущееСостояние] UNIQUEIDENTIFIER  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMNETLOCKDATA] (

	 [LockKey] VARCHAR(300)  NOT NULL,

	 [UserName] VARCHAR(300)  NOT NULL,

	 [LockDate] DATETIME  NULL,

	 PRIMARY KEY ([LockKey]))


CREATE TABLE [STORMSETTINGS] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Module] varchar(1000)  NULL,

	 [Name] varchar(255)  NULL,

	 [Value] text  NULL,

	 [User] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMAdvLimit] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [User] varchar(255)  NULL,

	 [Published] bit  NULL,

	 [Module] varchar(255)  NULL,

	 [Name] varchar(255)  NULL,

	 [Value] text  NULL,

	 [HotKeyData] int  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMFILTERSETTING] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Name] varchar(255)  NOT NULL,

	 [DataObjectView] varchar(255)  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMWEBSEARCH] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Name] varchar(255)  NOT NULL,

	 [Order] INT  NOT NULL,

	 [PresentView] varchar(255)  NOT NULL,

	 [DetailedView] varchar(255)  NOT NULL,

	 [FilterSetting_m0] uniqueidentifier  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMFILTERDETAIL] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Caption] varchar(255)  NOT NULL,

	 [DataObjectView] varchar(255)  NOT NULL,

	 [ConnectMasterProp] varchar(255)  NOT NULL,

	 [OwnerConnectProp] varchar(255)  NULL,

	 [FilterSetting_m0] uniqueidentifier  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMFILTERLOOKUP] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [DataObjectType] varchar(255)  NOT NULL,

	 [Container] varchar(255)  NULL,

	 [ContainerTag] varchar(255)  NULL,

	 [FieldsToView] varchar(255)  NULL,

	 [FilterSetting_m0] uniqueidentifier  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [UserSetting] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [AppName] varchar(256)  NULL,

	 [UserName] varchar(512)  NULL,

	 [UserGuid] uniqueidentifier  NULL,

	 [ModuleName] varchar(1024)  NULL,

	 [ModuleGuid] uniqueidentifier  NULL,

	 [SettName] varchar(256)  NULL,

	 [SettGuid] uniqueidentifier  NULL,

	 [SettLastAccessTime] DATETIME  NULL,

	 [StrVal] varchar(256)  NULL,

	 [TxtVal] varchar(max)  NULL,

	 [IntVal] int  NULL,

	 [BoolVal] bit  NULL,

	 [GuidVal] uniqueidentifier  NULL,

	 [DecimalVal] decimal(20,10)  NULL,

	 [DateTimeVal] DATETIME  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [ApplicationLog] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Category] varchar(64)  NULL,

	 [EventId] INT  NULL,

	 [Priority] INT  NULL,

	 [Severity] varchar(32)  NULL,

	 [Title] varchar(256)  NULL,

	 [Timestamp] DATETIME  NULL,

	 [MachineName] varchar(32)  NULL,

	 [AppDomainName] varchar(512)  NULL,

	 [ProcessId] varchar(256)  NULL,

	 [ProcessName] varchar(512)  NULL,

	 [ThreadName] varchar(512)  NULL,

	 [Win32ThreadId] varchar(128)  NULL,

	 [Message] varchar(2500)  NULL,

	 [FormattedMessage] varchar(max)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMAG] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Name] varchar(80)  NOT NULL,

	 [Login] varchar(50)  NULL,

	 [Pwd] varchar(50)  NULL,

	 [IsUser] bit  NOT NULL,

	 [IsGroup] bit  NOT NULL,

	 [IsRole] bit  NOT NULL,

	 [ConnString] varchar(255)  NULL,

	 [Enabled] bit  NULL,

	 [Email] varchar(80)  NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMLG] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Group_m0] uniqueidentifier  NOT NULL,

	 [User_m0] uniqueidentifier  NOT NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMAuObjType] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Name] nvarchar(255)  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMAuEntity] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [ObjectPrimaryKey] nvarchar(38)  NOT NULL,

	 [OperationTime] DATETIME  NOT NULL,

	 [OperationType] nvarchar(100)  NOT NULL,

	 [ExecutionResult] nvarchar(12)  NOT NULL,

	 [Source] nvarchar(255)  NOT NULL,

	 [SerializedField] nvarchar(max)  NULL,

	 [User_m0] uniqueidentifier  NOT NULL,

	 [ObjectType_m0] uniqueidentifier  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMAuField] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Field] nvarchar(100)  NOT NULL,

	 [OldValue] nvarchar(max)  NULL,

	 [NewValue] nvarchar(max)  NULL,

	 [MainChange_m0] uniqueidentifier  NULL,

	 [AuditEntity_m0] uniqueidentifier  NOT NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMI] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [User_m0] uniqueidentifier  NOT NULL,

	 [Agent_m0] uniqueidentifier  NOT NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [Session] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [UserKey] uniqueidentifier  NULL,

	 [StartedAt] datetime  NULL,

	 [LastAccess] datetime  NULL,

	 [Closed] bit  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMS] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Name] varchar(100)  NOT NULL,

	 [Type] varchar(100)  NULL,

	 [IsAttribute] bit  NOT NULL,

	 [IsOperation] bit  NOT NULL,

	 [IsView] bit  NOT NULL,

	 [IsClass] bit  NOT NULL,

	 [SharedOper] bit  NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMP] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Subject_m0] uniqueidentifier  NOT NULL,

	 [Agent_m0] uniqueidentifier  NOT NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMF] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [FilterText] varchar(MAX)  NULL,

	 [Name] varchar(255)  NULL,

	 [FilterTypeNView] varchar(255)  NULL,

	 [Subject_m0] uniqueidentifier  NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMAC] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [TypeAccess] varchar(7)  NULL,

	 [Filter_m0] uniqueidentifier  NULL,

	 [Permition_m0] uniqueidentifier  NOT NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMLO] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Class_m0] uniqueidentifier  NOT NULL,

	 [Operation_m0] uniqueidentifier  NOT NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMLA] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [View_m0] uniqueidentifier  NOT NULL,

	 [Attribute_m0] uniqueidentifier  NOT NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMLV] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [Class_m0] uniqueidentifier  NOT NULL,

	 [View_m0] uniqueidentifier  NOT NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))


CREATE TABLE [STORMLR] (

	 [primaryKey] uniqueidentifier  NOT NULL,

	 [StartDate] datetime  NULL,

	 [EndDate] datetime  NULL,

	 [Agent_m0] uniqueidentifier  NOT NULL,

	 [Role_m0] uniqueidentifier  NOT NULL,

	 [CreateTime] datetime  NULL,

	 [Creator] varchar(255)  NULL,

	 [EditTime] datetime  NULL,

	 [Editor] varchar(255)  NULL,

	 PRIMARY KEY ([primaryKey]))




 ALTER TABLE [ИсторияРасценок] ADD CONSTRAINT [ИсторияРасценок_FТипВелосипеда_0] FOREIGN KEY ([ТипВелосипеда]) REFERENCES [ТипВелосипеда]
CREATE INDEX ИсторияРасценок_IТипВелосипеда on [ИсторияРасценок] ([ТипВелосипеда])

 ALTER TABLE [ВелосипедВПеревозке] ADD CONSTRAINT [ВелосипедВПеревозке_FВелосипед_0] FOREIGN KEY ([Велосипед]) REFERENCES [Велосипед]
CREATE INDEX ВелосипедВПеревозке_IВелосипед on [ВелосипедВПеревозке] ([Велосипед])

 ALTER TABLE [ВелосипедВПеревозке] ADD CONSTRAINT [ВелосипедВПеревозке_FПеревозкаВелосипеда_0] FOREIGN KEY ([ПеревозкаВелосипеда]) REFERENCES [ПеревозкаВелосипеда]
CREATE INDEX ВелосипедВПеревозке_IПеревозкаВелосипеда on [ВелосипедВПеревозке] ([ПеревозкаВелосипеда])

 ALTER TABLE [ПрокатВелосипеда] ADD CONSTRAINT [ПрокатВелосипеда_FТочкаПроката_0] FOREIGN KEY ([ТочкаВыдачи]) REFERENCES [ТочкаПроката]
CREATE INDEX ПрокатВелосипеда_IТочкаВыдачи on [ПрокатВелосипеда] ([ТочкаВыдачи])

 ALTER TABLE [ПрокатВелосипеда] ADD CONSTRAINT [ПрокатВелосипеда_FКлиент_0] FOREIGN KEY ([Клиент]) REFERENCES [Клиент]
CREATE INDEX ПрокатВелосипеда_IКлиент on [ПрокатВелосипеда] ([Клиент])

 ALTER TABLE [ПрокатВелосипеда] ADD CONSTRAINT [ПрокатВелосипеда_FТочкаПроката_1] FOREIGN KEY ([ТочкаСдачи]) REFERENCES [ТочкаПроката]
CREATE INDEX ПрокатВелосипеда_IТочкаСдачи on [ПрокатВелосипеда] ([ТочкаСдачи])

 ALTER TABLE [ПрокатВелосипеда] ADD CONSTRAINT [ПрокатВелосипеда_FСотрудник_0] FOREIGN KEY ([Прокатчик_m0]) REFERENCES [Сотрудник]
CREATE INDEX ПрокатВелосипеда_IПрокатчик_m0 on [ПрокатВелосипеда] ([Прокатчик_m0])

 ALTER TABLE [ПрокатВелосипеда] ADD CONSTRAINT [ПрокатВелосипеда_FВелосипед_0] FOREIGN KEY ([Велосипед_m0]) REFERENCES [Велосипед]
CREATE INDEX ПрокатВелосипеда_IВелосипед_m0 on [ПрокатВелосипеда] ([Велосипед_m0])

 ALTER TABLE [ПеревозкаВелосипеда] ADD CONSTRAINT [ПеревозкаВелосипеда_FТочкаПроката_0] FOREIGN KEY ([КонечнаяТочка_m0]) REFERENCES [ТочкаПроката]
CREATE INDEX ПеревозкаВелосипеда_IКонечнаяТочка_m0 on [ПеревозкаВелосипеда] ([КонечнаяТочка_m0])

 ALTER TABLE [ПеревозкаВелосипеда] ADD CONSTRAINT [ПеревозкаВелосипеда_FТочкаПроката_1] FOREIGN KEY ([НачальнаяТочка_m0]) REFERENCES [ТочкаПроката]
CREATE INDEX ПеревозкаВелосипеда_IНачальнаяТочка_m0 on [ПеревозкаВелосипеда] ([НачальнаяТочка_m0])

 ALTER TABLE [ПеревозкаВелосипеда] ADD CONSTRAINT [ПеревозкаВелосипеда_FСотрудник_0] FOREIGN KEY ([Водитель_m0]) REFERENCES [Сотрудник]
CREATE INDEX ПеревозкаВелосипеда_IВодитель_m0 on [ПеревозкаВелосипеда] ([Водитель_m0])

 ALTER TABLE [ИсторияСостояний] ADD CONSTRAINT [ИсторияСостояний_FСостояниеВелосипеда_0] FOREIGN KEY ([СостояниеВелосипеда]) REFERENCES [СостояниеВелосипеда]
CREATE INDEX ИсторияСостояний_IСостояниеВелосипеда on [ИсторияСостояний] ([СостояниеВелосипеда])

 ALTER TABLE [ИсторияСостояний] ADD CONSTRAINT [ИсторияСостояний_FВелосипед_0] FOREIGN KEY ([Велосипед]) REFERENCES [Велосипед]
CREATE INDEX ИсторияСостояний_IВелосипед on [ИсторияСостояний] ([Велосипед])

 ALTER TABLE [Велосипед] ADD CONSTRAINT [Велосипед_FТочкаПроката_0] FOREIGN KEY ([ТочкаПроката]) REFERENCES [ТочкаПроката]
CREATE INDEX Велосипед_IТочкаПроката on [Велосипед] ([ТочкаПроката])

 ALTER TABLE [Велосипед] ADD CONSTRAINT [Велосипед_FТипВелосипеда_0] FOREIGN KEY ([ТипВелосипеда]) REFERENCES [ТипВелосипеда]
CREATE INDEX Велосипед_IТипВелосипеда on [Велосипед] ([ТипВелосипеда])

 ALTER TABLE [Велосипед] ADD CONSTRAINT [Велосипед_FСостояниеВелосипеда_0] FOREIGN KEY ([ТекущееСостояние]) REFERENCES [СостояниеВелосипеда]
CREATE INDEX Велосипед_IТекущееСостояние on [Велосипед] ([ТекущееСостояние])

 ALTER TABLE [STORMWEBSEARCH] ADD CONSTRAINT [STORMWEBSEARCH_FSTORMFILTERSETTING_0] FOREIGN KEY ([FilterSetting_m0]) REFERENCES [STORMFILTERSETTING]

 ALTER TABLE [STORMFILTERDETAIL] ADD CONSTRAINT [STORMFILTERDETAIL_FSTORMFILTERSETTING_0] FOREIGN KEY ([FilterSetting_m0]) REFERENCES [STORMFILTERSETTING]

 ALTER TABLE [STORMFILTERLOOKUP] ADD CONSTRAINT [STORMFILTERLOOKUP_FSTORMFILTERSETTING_0] FOREIGN KEY ([FilterSetting_m0]) REFERENCES [STORMFILTERSETTING]

 ALTER TABLE [STORMLG] ADD CONSTRAINT [STORMLG_FSTORMAG_0] FOREIGN KEY ([Group_m0]) REFERENCES [STORMAG]

 ALTER TABLE [STORMLG] ADD CONSTRAINT [STORMLG_FSTORMAG_1] FOREIGN KEY ([User_m0]) REFERENCES [STORMAG]

 ALTER TABLE [STORMAuEntity] ADD CONSTRAINT [STORMAuEntity_FSTORMAG_0] FOREIGN KEY ([User_m0]) REFERENCES [STORMAG]

 ALTER TABLE [STORMAuEntity] ADD CONSTRAINT [STORMAuEntity_FSTORMAuObjType_0] FOREIGN KEY ([ObjectType_m0]) REFERENCES [STORMAuObjType]

 ALTER TABLE [STORMAuField] ADD CONSTRAINT [STORMAuField_FSTORMAuField_0] FOREIGN KEY ([MainChange_m0]) REFERENCES [STORMAuField]

 ALTER TABLE [STORMAuField] ADD CONSTRAINT [STORMAuField_FSTORMAuEntity_0] FOREIGN KEY ([AuditEntity_m0]) REFERENCES [STORMAuEntity]

 ALTER TABLE [STORMI] ADD CONSTRAINT [STORMI_FSTORMAG_0] FOREIGN KEY ([User_m0]) REFERENCES [STORMAG]

 ALTER TABLE [STORMI] ADD CONSTRAINT [STORMI_FSTORMAG_1] FOREIGN KEY ([Agent_m0]) REFERENCES [STORMAG]

 ALTER TABLE [STORMP] ADD CONSTRAINT [STORMP_FSTORMS_0] FOREIGN KEY ([Subject_m0]) REFERENCES [STORMS]

 ALTER TABLE [STORMP] ADD CONSTRAINT [STORMP_FSTORMAG_0] FOREIGN KEY ([Agent_m0]) REFERENCES [STORMAG]

 ALTER TABLE [STORMF] ADD CONSTRAINT [STORMF_FSTORMS_0] FOREIGN KEY ([Subject_m0]) REFERENCES [STORMS]

 ALTER TABLE [STORMAC] ADD CONSTRAINT [STORMAC_FSTORMF_0] FOREIGN KEY ([Filter_m0]) REFERENCES [STORMF]

 ALTER TABLE [STORMAC] ADD CONSTRAINT [STORMAC_FSTORMP_0] FOREIGN KEY ([Permition_m0]) REFERENCES [STORMP]

 ALTER TABLE [STORMLO] ADD CONSTRAINT [STORMLO_FSTORMS_0] FOREIGN KEY ([Class_m0]) REFERENCES [STORMS]

 ALTER TABLE [STORMLO] ADD CONSTRAINT [STORMLO_FSTORMS_1] FOREIGN KEY ([Operation_m0]) REFERENCES [STORMS]

 ALTER TABLE [STORMLA] ADD CONSTRAINT [STORMLA_FSTORMS_0] FOREIGN KEY ([View_m0]) REFERENCES [STORMS]

 ALTER TABLE [STORMLA] ADD CONSTRAINT [STORMLA_FSTORMS_1] FOREIGN KEY ([Attribute_m0]) REFERENCES [STORMS]

 ALTER TABLE [STORMLV] ADD CONSTRAINT [STORMLV_FSTORMS_0] FOREIGN KEY ([Class_m0]) REFERENCES [STORMS]

 ALTER TABLE [STORMLV] ADD CONSTRAINT [STORMLV_FSTORMS_1] FOREIGN KEY ([View_m0]) REFERENCES [STORMS]

 ALTER TABLE [STORMLR] ADD CONSTRAINT [STORMLR_FSTORMAG_0] FOREIGN KEY ([Agent_m0]) REFERENCES [STORMAG]

 ALTER TABLE [STORMLR] ADD CONSTRAINT [STORMLR_FSTORMAG_1] FOREIGN KEY ([Role_m0]) REFERENCES [STORMAG]
