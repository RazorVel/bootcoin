use bootcoin

go
insert into Users
values
	('e6e0b714-ab17-40c4-bf49-a9c94d9a4433', 'merchant', 'merchant@root.com', 'JyO0fNvjsi;:JiSjgj;KJIU923asJK::', 'Merchant', 0)

insert into Profiles
values
	(NEWID(), '', NULL, '', '', '', '', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433')

go 

insert into Users
values 
	('df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'razor', 'razor@gmail.com', '123', 'Admin', 0),
	('c870d433-dfba-4bc9-9d83-1169471daf07', 'velvet', 'velvet@gmail.com', '1234', 'Admin', 0),
	('4a2c0ee9-a422-4b62-80b9-b098672199f5', 'razorvelvet', 'razorvelvet@gmail.com', '123', 'Admin', 0)

insert into Profiles
values
	(NEWID(), '', NULL, '', '', '', '', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad'),
	(NEWID(), '', NULL, '', '', '', '', 'c870d433-dfba-4bc9-9d83-1169471daf07'),
	(NEWID(), '', NULL, '', '', '', '', '4a2c0ee9-a422-4b62-80b9-b098672199f5')

go

insert into Users
values
	('84467d5d-843b-41f3-8146-fd76e298587b', 'orely', 'orely@gmail.com', '1234', 'Participant', 0),
	('e696370a-69b8-4742-a6c6-2f33057bf5d5', 'teddy', 'teddy@gmail.com', '123'	, 'Participant', 0),
	('730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d', 'beta', 'beta@gmail.com', '123', 'Participant', 0),
	('c108add8-c40d-4fb5-8d7b-f948091856b2', 'alpha', 'alpha@gmail.com', '1234', 'Participant', 0),
	('2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a', 'omega', 'omega@gmail.com', '123', 'Participant', 0),
	('e73d2348-c324-41bf-bd94-abc5a4b43529', 'theta', 'theta@gmail.com', '1234', 'Participant', 0),
	('adb9f128-c310-48db-8e9f-aa66c07d77b5' , 'wendy', 'wendy@gmail.com', '123', 'Participant', 0),
	('425ce891-9fc4-4393-b29b-d220e75a89e7' , 'manny', 'manny@gmail.com', '1234', 'Participant', 0),
	('1b6c06ce-1d7b-4090-971c-6d52c145cac8' , 'user', 'user@gmail.com', '123', 'Participant', 0),
	('fa8f2a8a-1102-4ac9-897a-1a11cb877607' , 'penny', 'penny@gmail.com', '1234', 'Participant', 0),
	('7b682342-651c-47d8-bdc5-d8c0fb34ee36' , 'kenny', 'kenny@gmail.com', '123', 'Participant', 0),
	('d614db62-e5b9-4913-96a0-998c3b571391' , 'yelly', 'yelly@gmail.com', '1234', 'Participant', 0),
	('8b102f21-9e8b-4576-84a4-0eac5b63fdf3' , 'elly', 'elly@gmail.com', '1234', 'Participant', 0),
	('8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd' , 'Andy', 'andy@gmail.com', '1234', 'Participant', 0),
	('b4273518-9bd4-476d-b8bc-787cada6ea38' , 'venny', 'venny@gmail.com', '123', 'Participant', 0),
	('0d88048a-9637-419e-9254-00a01377f964' , 'fenny', 'fenny@gmail.com', '123', 'Participant', 0),
	('68dd35ed-49cb-403b-89e4-53d3e6a76510' , 'jenny', 'jenny@gmail.com', '1234', 'Participant', 0),
	('e5c6a766-ff62-448f-ae13-02f82dcddcc0' , 'lenny', 'lenny@gmail.com', '123', 'Participant', 0),
	('c79e4f8e-138c-4ae8-a6b5-839ffe81637a' , 'sally', 'sally@gmail.com', '123', 'Participant', 0),
	('45d6f7d9-9373-4e40-af5e-bb799fa74e71' , 'ranny', 'ranny@gmail.com', '1234', 'Participant', 0),
	('6ea4cb39-4124-4cdd-a877-e62b86711cf8' , 'gary', 'gary@gmail.com', '1234', 'Participant', 0),
	('f08f6a44-b2da-4ee4-a58c-439d7bb610e5' , 'gamma', 'gamma@gmail.com', '1234', 'Participant', 0),
	('cf4aab22-7c09-4f14-89ae-7af7691098f8' , 'quinny', 'quinny@gmail.com', '123', 'Participant', 0),
	('7a4d2f5b-2d79-4d8d-b8b5-def36908a30f' , 'nancy', 'nancy@gmail.com', '1234', 'Participant', 0),
	('29655c9f-cd5c-4afd-a1d2-1d373616622e' , 'cindy', 'cindy@gmail.com', '1234', 'Participant', 0),
	('26d527e8-cbef-4a60-a057-fcf549ac6e58' , 'budy', 'budy@gmail.com', '123', 'Participant', 0),
	('3306f55a-6bfa-466b-a558-200fcd1d13be' , 'ivany', 'ivany@gmail.com', '123', 'Participant', 0),
	('74efe561-0e2f-4401-a81f-6934f0c86033' , 'denny', 'denny@gmail.com', '1234', 'Participant', 0),
	('6bd97b1f-af97-4027-ae59-078c99436c11' , 'Unity', 'unity@gmail.com', '1234', 'Participant', 0),
	('dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6' , 'harry', 'harry@gmail.com', '123', 'Participant', 0),
	('7fd61ce7-a04e-40f7-b164-fe0ee9e8b8a4' , 'xacky', 'xacky@gmail.com', '123', 'Participant', 0),
	('491601bd-4d1e-4fca-838b-5ef06e39bbf7' , 'zelly', 'zelly@gmail.com', '1234', 'Participant', 0)

insert into Profiles
values
	(NEWID(), '', NULL, '', '', '', '' , '84467d5d-843b-41f3-8146-fd76e298587b'),
	(NEWID(), '', NULL, '', '', '', '' , 'e696370a-69b8-4742-a6c6-2f33057bf5d5'),
	(NEWID(), '', NULL, '', '', '', '' , '730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d'),
	(NEWID(), '', NULL, '', '', '', '' , 'c108add8-c40d-4fb5-8d7b-f948091856b2'),
	(NEWID(), '', NULL, '', '', '', '' , '2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a'),
	(NEWID(), '', NULL, '', '', '', '' , 'e73d2348-c324-41bf-bd94-abc5a4b43529'),
	(NEWID(), '', NULL, '', '', '', '' , 'adb9f128-c310-48db-8e9f-aa66c07d77b5'),
	(NEWID(), '', NULL, '', '', '', '' , '425ce891-9fc4-4393-b29b-d220e75a89e7'),
	(NEWID(), '', NULL, '', '', '', '' , '1b6c06ce-1d7b-4090-971c-6d52c145cac8'),
	(NEWID(), '', NULL, '', '', '', '' , 'fa8f2a8a-1102-4ac9-897a-1a11cb877607'),
	(NEWID(), '', NULL, '', '', '', '' , '7b682342-651c-47d8-bdc5-d8c0fb34ee36'),
	(NEWID(), '', NULL, '', '', '', '' , 'd614db62-e5b9-4913-96a0-998c3b571391'),
	(NEWID(), '', NULL, '', '', '', '' , '8b102f21-9e8b-4576-84a4-0eac5b63fdf3'),
	(NEWID(), '', NULL, '', '', '', '' , '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd'),
	(NEWID(), '', NULL, '', '', '', '' , 'b4273518-9bd4-476d-b8bc-787cada6ea38'),
	(NEWID(), '', NULL, '', '', '', '' , '0d88048a-9637-419e-9254-00a01377f964'),
	(NEWID(), '', NULL, '', '', '', '' , '68dd35ed-49cb-403b-89e4-53d3e6a76510'),
	(NEWID(), '', NULL, '', '', '', '' , 'e5c6a766-ff62-448f-ae13-02f82dcddcc0'),
	(NEWID(), '', NULL, '', '', '', '' , 'c79e4f8e-138c-4ae8-a6b5-839ffe81637a'),
	(NEWID(), '', NULL, '', '', '', '' , '45d6f7d9-9373-4e40-af5e-bb799fa74e71'),
	(NEWID(), '', NULL, '', '', '', '' , '6ea4cb39-4124-4cdd-a877-e62b86711cf8'),
	(NEWID(), '', NULL, '', '', '', '' , 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5'),
	(NEWID(), '', NULL, '', '', '', '' , 'cf4aab22-7c09-4f14-89ae-7af7691098f8'),
	(NEWID(), '', NULL, '', '', '', '' , '7a4d2f5b-2d79-4d8d-b8b5-def36908a30f'),
	(NEWID(), '', NULL, '', '', '', '' , '29655c9f-cd5c-4afd-a1d2-1d373616622e'),
	(NEWID(), '', NULL, '', '', '', '' , '26d527e8-cbef-4a60-a057-fcf549ac6e58'),
	(NEWID(), '', NULL, '', '', '', '' , '3306f55a-6bfa-466b-a558-200fcd1d13be'),
	(NEWID(), '', NULL, '', '', '', '' , '74efe561-0e2f-4401-a81f-6934f0c86033'),
	(NEWID(), '', NULL, '', '', '', '' , '6bd97b1f-af97-4027-ae59-078c99436c11'),
	(NEWID(), '', NULL, '', '', '', '' , 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6'),
	(NEWID(), '', NULL, '', '', '', '' , '7fd61ce7-a04e-40f7-b164-fe0ee9e8b8a4'),
	(NEWID(), '', NULL, '', '', '', '' , '491601bd-4d1e-4fca-838b-5ef06e39bbf7')

go

insert into TransactionHeaders
values
	('f3fdba67-e6a9-4533-a84e-f3070506a82a', 'c870d433-dfba-4bc9-9d83-1169471daf07', '2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a', '2000-02-11', 'Input'),
	('e1b13d82-7de1-4a80-888e-7b1c4526fcc4', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', '2000-02-11', 'Input'),
	('bf34cdb5-4e27-4426-8d5b-41014f6fdf34', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6', '2000-02-11', 'Input'),
	('7ffdc052-408b-48cc-9f18-1cab243e2dcf', 'c870d433-dfba-4bc9-9d83-1169471daf07', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', '2000-02-11', 'Input'),
	('34e66ecf-08c5-42c0-a732-c4be817dd526', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6', '2000-02-11', 'Input'),
	('2171afe5-41db-4058-b77a-9a6862e59129', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6', '2000-02-11', 'Input'),
	('20cc0473-048b-4244-b384-8629e82d163e', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d', '2000-07-15', 'Input'),
	('312f7f42-bca7-4dcd-90f4-b05aa713e06c', '6bd97b1f-af97-4027-ae59-078c99436c11', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2000-07-15', 'Redeem'),
	('e621eb1a-24fd-4563-8193-d8dd0fdc1cf3', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2000-07-15', 'Redeem'),
	('41b003f0-a5b5-42e0-9c8d-5cf9bea2f105', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', '2000-07-15', 'Input'),
	('b845c1c1-c753-4723-9da3-fcfcf259e302', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2000-07-15', 'Input'),
	('0f1a07b0-293c-4540-84e2-c6b3394ab7ff', '2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2000-07-15', 'Redeem'),
	('f24c7248-ac2d-42ac-94a3-7f838e4526a9', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6', '2000-09-18', 'Input'),
	('e2c5fd2c-32ae-44a0-82fe-ff03ce3f89ec', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', '2000-09-18', 'Input'),
	('205e3da4-a500-4dcb-bb83-34f179773897', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2000-09-18', 'Input'),
	('1549caeb-126d-421b-877b-af2610566f2f', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d', '2000-09-18', 'Input'),
	('5a696412-3132-460a-afad-b6d2a4170a95', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a', '2000-09-18', 'Input'),
	('63fa9f81-c732-4acd-b633-cef59c755f22', 'c870d433-dfba-4bc9-9d83-1169471daf07', '84467d5d-843b-41f3-8146-fd76e298587b', '2000-09-18', 'Input'),
	('c281b706-2c38-4fdd-9240-2978e6dcb161', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'c108add8-c40d-4fb5-8d7b-f948091856b2', '2001-01-11', 'Input'),
	('b7842e0c-9b70-4aa7-9bec-ac81f899f22a', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd', '2001-01-11', 'Input'),
	('72f895e8-a808-4e87-a906-2b47eebaa872', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', '2001-01-11', 'Input'),
	('bf3beb17-43b5-44f0-ba3b-a64111899955', '6bd97b1f-af97-4027-ae59-078c99436c11', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2001-01-11', 'Redeem'),
	('258ff673-530e-475c-914a-76c3e64065af', '730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2001-01-11', 'Redeem'),
	('7b8e8aeb-9ead-4b06-b700-e120c54247f2', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2001-01-11', 'Input'),
	('ea6e834f-210b-45a4-96ea-bbc25f1c4c2c', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '84467d5d-843b-41f3-8146-fd76e298587b', '2001-08-12', 'Input'),
	('4d2c3df4-3956-4007-8097-e9de5e75a69d', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '7b682342-651c-47d8-bdc5-d8c0fb34ee36', '2001-08-12', 'Input'),
	('98431ed8-f680-4905-9fb1-668884f04195', 'c870d433-dfba-4bc9-9d83-1169471daf07', '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd', '2001-08-12', 'Input'),
	('d405ec12-b036-4d85-8363-8ba45912ba2d', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2001-08-12', 'Input'),
	('df29d5bb-d829-4b30-812c-5fc4f3a619cd', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'e73d2348-c324-41bf-bd94-abc5a4b43529', '2001-08-12', 'Input'),
	('d9a61724-f849-4f6d-ab98-1de04d184445', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'e73d2348-c324-41bf-bd94-abc5a4b43529', '2001-08-12', 'Input'),
	('047abd49-2521-482d-aee6-524fb7575b6c', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'e73d2348-c324-41bf-bd94-abc5a4b43529', '2001-08-19', 'Input'),
	('8183f9fd-609e-485f-a6c8-cbf4f68a5e12', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2001-08-19', 'Redeem'),
	('794a6baf-075b-472d-b736-f94723c77e03', '7b682342-651c-47d8-bdc5-d8c0fb34ee36', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2001-08-19', 'Redeem'),
	('fcadfdd6-0b2a-46ad-8783-f2b797ff6fed', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'e73d2348-c324-41bf-bd94-abc5a4b43529', '2001-08-19', 'Input'),
	('fb89f63c-3d1a-4042-9e35-164c38699cc5', '730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2001-08-19', 'Redeem'),
	('63b7dfe9-3f60-4609-83c5-1cd64d396b1d', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2001-08-19', 'Redeem'),
	('64e814b0-5567-41cc-8f07-f32325360d2b', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '7b682342-651c-47d8-bdc5-d8c0fb34ee36', '2002-04-11', 'Input'),
	('316f41e8-9bef-4748-b6b7-22fa33bdd9d5', 'c870d433-dfba-4bc9-9d83-1169471daf07', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', '2002-04-11', 'Input'),
	('ceb67a24-7baa-471e-9817-75f6f310455d', '2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2002-04-11', 'Redeem'),
	('e03bb58c-d5c0-43d8-822a-530402b47592', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2002-04-11', 'Input'),
	('2cbec3f3-87cc-423a-9dff-e71493fd31d9', 'c870d433-dfba-4bc9-9d83-1169471daf07', '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd', '2002-04-11', 'Input'),
	('c6bd82d0-ff90-498f-ba67-a402dd669847', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a', '2002-04-11', 'Input'),
	('6d4c17c2-5021-4903-9136-6c7e051da1df', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '6bd97b1f-af97-4027-ae59-078c99436c11', '2002-06-17', 'Input'),
	('04b870ba-e37a-4abe-888c-74cb5e62a1a1', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd', '2002-06-17', 'Input'),
	('0d5eb9b5-3b61-44f5-9fdb-f8241e732c67', 'c870d433-dfba-4bc9-9d83-1169471daf07', '2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a', '2002-06-17', 'Input'),
	('59479fb8-ac37-4828-9bd7-db2f070f1326', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d', '2002-06-17', 'Input'),
	('36954ed8-6973-4f6e-988e-e4cba6a4a3cd', 'c870d433-dfba-4bc9-9d83-1169471daf07', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', '2002-06-17', 'Input'),
	('2418854c-9ad8-4beb-a14d-4d9c885cfc38', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'c108add8-c40d-4fb5-8d7b-f948091856b2', '2002-06-17', 'Input'),
	('e96964fa-974c-48e7-b448-bb4461f06dbc', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'e73d2348-c324-41bf-bd94-abc5a4b43529', '2002-07-19', 'Input'),
	('7d81c7d6-9af0-4898-a629-b28414b22ba0', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a', '2002-07-19', 'Input'),
	('1f5df9c5-a73f-4b3b-b9de-49d8a29686f3', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '7b682342-651c-47d8-bdc5-d8c0fb34ee36', '2002-07-19', 'Input'),
	('e52a4928-2f84-455c-8925-bddcbbcce792', '730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2002-07-19', 'Redeem'),
	('dca56029-f4ff-4d2d-913d-ea9961ead186', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', '2002-07-19', 'Input'),
	('fc1a8f8d-1a8c-4958-b82c-46450af17e3d', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6', '2002-07-19', 'Input'),
	('05d363ed-060e-4f97-9f46-70b1f4000e20', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6', '2002-08-12', 'Input'),
	('af822b68-7d72-4840-bc7e-15a03bd30b23', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', '2002-08-12', 'Input'),
	('6b501145-f1df-4880-9364-80df9503f4a9', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'c108add8-c40d-4fb5-8d7b-f948091856b2', '2002-08-12', 'Input'),
	('44091270-fb3d-4ff9-a588-cc6f09d629c6', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'e73d2348-c324-41bf-bd94-abc5a4b43529', '2002-08-12', 'Input'),
	('d7179086-b37a-4925-b79b-739bad2cb3e0', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '6bd97b1f-af97-4027-ae59-078c99436c11', '2002-08-12', 'Input'),
	('c36be656-0c6e-4233-b290-411edab3a4dc', '6bd97b1f-af97-4027-ae59-078c99436c11', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2002-08-12', 'Redeem'),
	('012208c6-c86a-40c5-a63b-40c2161b7fa3', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2002-09-14', 'Input'),
	('2d0a42b8-84ad-4af6-b0f0-bf8c327716b8', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', '2002-09-14', 'Input'),
	('4af947c9-a516-4e40-b8b1-89a9923dc1db', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'c108add8-c40d-4fb5-8d7b-f948091856b2', '2002-09-14', 'Input'),
	('8669b8bd-93b0-4ed7-83f6-e99333a8d7de', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2002-09-14', 'Input'),
	('0aa1dc8f-7f43-438f-ae19-07cb26b740cd', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2002-09-14', 'Input'),
	('16d0d069-1cdf-4dc2-b495-97a93d5c70bb', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '84467d5d-843b-41f3-8146-fd76e298587b', '2002-09-14', 'Input'),
	('65588ac8-e153-4aec-a328-9220ce45be84', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '84467d5d-843b-41f3-8146-fd76e298587b', '2002-09-16', 'Input'),
	('1a6b66f9-430c-411c-85d3-49a1c5ab8cec', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'c108add8-c40d-4fb5-8d7b-f948091856b2', '2002-09-16', 'Input'),
	('472ffff3-8108-46fc-b1b2-d8f0c0ae48a4', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2002-09-16', 'Input'),
	('8ec46b0b-1511-4559-98c4-354ede3e8a31', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', '2002-09-16', 'Input'),
	('6c95e56f-51ea-4e8d-8507-541e07d13f48', 'c870d433-dfba-4bc9-9d83-1169471daf07', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', '2002-09-16', 'Input'),
	('067219dc-8c31-4c5d-b55f-9e01673f956f', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6', '2002-09-16', 'Input'),
	('589fb973-ff8a-4606-a2cf-75eef3642090', 'c870d433-dfba-4bc9-9d83-1169471daf07', '6bd97b1f-af97-4027-ae59-078c99436c11', '2003-03-11', 'Input'),
	('9b71dbbc-ff18-4641-9dec-96ea553a411d', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', '2003-03-11', 'Input'),
	('19ffcea7-3fd0-4e50-826d-e3b28e414549', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', '2003-03-11', 'Input'),
	('b1384ff2-18c7-4f64-b02a-39ef0cb47975', 'c870d433-dfba-4bc9-9d83-1169471daf07', '7b682342-651c-47d8-bdc5-d8c0fb34ee36', '2003-03-11', 'Input'),
	('12fe08c5-965a-4bb8-ac27-8e1debe35d3c', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6', '2003-03-11', 'Input'),
	('4d3f8e39-037a-4766-975f-0179d4a10e14', 'e696370a-69b8-4742-a6c6-2f33057bf5d5', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2003-03-11', 'Redeem'),
	('5050872c-771b-4c6f-ae45-b926452c5254', 'e73d2348-c324-41bf-bd94-abc5a4b43529', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2003-04-19', 'Redeem'),
	('f5beb5eb-86cf-4a5f-a9ab-44cf66220669', 'c870d433-dfba-4bc9-9d83-1169471daf07', '6bd97b1f-af97-4027-ae59-078c99436c11', '2003-04-19', 'Input'),
	('aaabe1bd-861d-4e16-a7d0-fb66135d53ab', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'c108add8-c40d-4fb5-8d7b-f948091856b2', '2003-04-19', 'Input'),
	('04580cd9-55d1-4880-a02c-284ba4be9dff', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd', '2003-04-19', 'Input'),
	('cf48915e-ccc6-452a-8e93-2b51e91c2617', '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2003-04-19', 'Redeem'),
	('ac6d64e7-fed5-4658-9e02-a48620472edd', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', '2003-04-19', 'Input'),
	('ec0d2569-2a77-442d-abc5-21db89cfd6e2', 'c870d433-dfba-4bc9-9d83-1169471daf07', '1b6c06ce-1d7b-4090-971c-6d52c145cac8', '2003-06-19', 'Input'),
	('9866c04b-91b6-4a55-aeda-dd80a1b1406b', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', '2003-06-19', 'Input'),
	('0992399e-e69f-4397-bf5a-2dd2feea7585', 'c870d433-dfba-4bc9-9d83-1169471daf07', '6bd97b1f-af97-4027-ae59-078c99436c11', '2003-06-19', 'Input'),
	('557e6f67-c811-4e7e-9a52-7182721caed3', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d', '2003-06-19', 'Input'),
	('41fb841e-a5d8-4809-b5b9-f5f015bd1029', '4a2c0ee9-a422-4b62-80b9-b098672199f5', '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd', '2003-06-19', 'Input'),
	('e07ab7bf-1289-4c76-b691-fb525a147cde', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5', '2003-06-19', 'Input'),
	('9d952e32-d77f-41c5-b4e2-70ff62d7a48c', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'c108add8-c40d-4fb5-8d7b-f948091856b2', '2003-08-16', 'Input'),
	('81400ccf-64a7-4ba9-b1b2-e28e22d839a0', 'c108add8-c40d-4fb5-8d7b-f948091856b2', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2003-08-16', 'Redeem'),
	('41099ad1-3106-47f4-aaf8-ecbad8b7dc52', 'c870d433-dfba-4bc9-9d83-1169471daf07', '7b682342-651c-47d8-bdc5-d8c0fb34ee36', '2003-08-16', 'Input'),
	('793547d4-de42-4d40-a1df-bfee07fd0551', 'c870d433-dfba-4bc9-9d83-1169471daf07', 'c108add8-c40d-4fb5-8d7b-f948091856b2', '2003-08-16', 'Input'),
	('9775dd8e-6666-44dd-aaca-3b107ae39bf9', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', 'e73d2348-c324-41bf-bd94-abc5a4b43529', '2003-08-16', 'Input'),
	('642bdd5f-8be4-48d5-b70c-5e3f091d0358', '4a2c0ee9-a422-4b62-80b9-b098672199f5', 'e73d2348-c324-41bf-bd94-abc5a4b43529', '2003-08-16', 'Input'),
	('53e6da12-7324-48c3-a780-6a4f1f4503b1', 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2003-09-17', 'Redeem'),
	('b69ac09b-318c-4c99-a8f7-d5d1097dedc6', 'c870d433-dfba-4bc9-9d83-1169471daf07', '84467d5d-843b-41f3-8146-fd76e298587b', '2003-09-17', 'Input'),
	('34eb1c64-f8ac-4c0b-9f85-9d9b5f4e8ce5', 'df0f35ef-9790-4e90-a2f3-a8399d85ffad', '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd', '2003-09-17', 'Input'),
	('0eefcba0-3825-4277-b9ad-65bb547b0462', 'c108add8-c40d-4fb5-8d7b-f948091856b2', 'e6e0b714-ab17-40c4-bf49-a9c94d9a4433', '2003-09-17', 'Redeem')


insert into TransactionDetails
values
	('f3fdba67-e6a9-4533-a84e-f3070506a82a', 249, 249),
	('e1b13d82-7de1-4a80-888e-7b1c4526fcc4', 281, 281),
	('bf34cdb5-4e27-4426-8d5b-41014f6fdf34', 378, 378),
	('7ffdc052-408b-48cc-9f18-1cab243e2dcf', 285, 285),
	('34e66ecf-08c5-42c0-a732-c4be817dd526', 474, 852),
	('2171afe5-41db-4058-b77a-9a6862e59129', 465, 1317),
	('20cc0473-048b-4244-b384-8629e82d163e', 456, 456),
	('312f7f42-bca7-4dcd-90f4-b05aa713e06c', 0, 0),
	('e621eb1a-24fd-4563-8193-d8dd0fdc1cf3', -175, 110),
	('41b003f0-a5b5-42e0-9c8d-5cf9bea2f105', 92, 373),
	('b845c1c1-c753-4723-9da3-fcfcf259e302', 124, 124),
	('0f1a07b0-293c-4540-84e2-c6b3394ab7ff', -190, 59),
	('f24c7248-ac2d-42ac-94a3-7f838e4526a9', 192, 1509),
	('e2c5fd2c-32ae-44a0-82fe-ff03ce3f89ec', 497, 607),
	('205e3da4-a500-4dcb-bb83-34f179773897', 254, 378),
	('1549caeb-126d-421b-877b-af2610566f2f', 228, 684),
	('5a696412-3132-460a-afad-b6d2a4170a95', 49, 108),
	('63fa9f81-c732-4acd-b633-cef59c755f22', 74, 74),
	('c281b706-2c38-4fdd-9240-2978e6dcb161', 252, 252),
	('b7842e0c-9b70-4aa7-9bec-ac81f899f22a', 295, 295),
	('72f895e8-a808-4e87-a906-2b47eebaa872', 270, 643),
	('bf3beb17-43b5-44f0-ba3b-a64111899955', 0, 0),
	('258ff673-530e-475c-914a-76c3e64065af', -572, 112),
	('7b8e8aeb-9ead-4b06-b700-e120c54247f2', 303, 681),
	('ea6e834f-210b-45a4-96ea-bbc25f1c4c2c', 223, 297),
	('4d2c3df4-3956-4007-8097-e9de5e75a69d', 248, 248),
	('98431ed8-f680-4905-9fb1-668884f04195', 425, 720),
	('d405ec12-b036-4d85-8363-8ba45912ba2d', 67, 748),
	('df29d5bb-d829-4b30-812c-5fc4f3a619cd', 198, 198),
	('d9a61724-f849-4f6d-ab98-1de04d184445', 154, 352),
	('047abd49-2521-482d-aee6-524fb7575b6c', 110, 462),
	('8183f9fd-609e-485f-a6c8-cbf4f68a5e12', -173, 470),
	('794a6baf-075b-472d-b736-f94723c77e03', -218, 30),
	('fcadfdd6-0b2a-46ad-8783-f2b797ff6fed', 236, 698),
	('fb89f63c-3d1a-4042-9e35-164c38699cc5', -41, 71),
	('63b7dfe9-3f60-4609-83c5-1cd64d396b1d', -402, 68),
	('64e814b0-5567-41cc-8f07-f32325360d2b', 362, 392),
	('316f41e8-9bef-4748-b6b7-22fa33bdd9d5', 325, 932),
	('ceb67a24-7baa-471e-9817-75f6f310455d', -38, 70),
	('e03bb58c-d5c0-43d8-822a-530402b47592', 166, 914),
	('2cbec3f3-87cc-423a-9dff-e71493fd31d9', 387, 1107),
	('c6bd82d0-ff90-498f-ba67-a402dd669847', 5, 75),
	('6d4c17c2-5021-4903-9136-6c7e051da1df', 111, 111),
	('04b870ba-e37a-4abe-888c-74cb5e62a1a1', 18, 1125),
	('0d5eb9b5-3b61-44f5-9fdb-f8241e732c67', 406, 481),
	('59479fb8-ac37-4828-9bd7-db2f070f1326', 175, 246),
	('36954ed8-6973-4f6e-988e-e4cba6a4a3cd', 402, 1334),
	('2418854c-9ad8-4beb-a14d-4d9c885cfc38', 15, 267),
	('e96964fa-974c-48e7-b448-bb4461f06dbc', 211, 909),
	('7d81c7d6-9af0-4898-a629-b28414b22ba0', 82, 563),
	('1f5df9c5-a73f-4b3b-b9de-49d8a29686f3', 280, 672),
	('e52a4928-2f84-455c-8925-bddcbbcce792', -13, 233),
	('dca56029-f4ff-4d2d-913d-ea9961ead186', 333, 401),
	('fc1a8f8d-1a8c-4958-b82c-46450af17e3d', 308, 1817),
	('05d363ed-060e-4f97-9f46-70b1f4000e20', 270, 2087),
	('af822b68-7d72-4840-bc7e-15a03bd30b23', 291, 1625),
	('6b501145-f1df-4880-9364-80df9503f4a9', 345, 612),
	('44091270-fb3d-4ff9-a588-cc6f09d629c6', 274, 1183),
	('d7179086-b37a-4925-b79b-739bad2cb3e0', 174, 285),
	('c36be656-0c6e-4233-b290-411edab3a4dc', -86, 199),
	('012208c6-c86a-40c5-a63b-40c2161b7fa3', 154, 1068),
	('2d0a42b8-84ad-4af6-b0f0-bf8c327716b8', 274, 675),
	('4af947c9-a516-4e40-b8b1-89a9923dc1db', 189, 801),
	('8669b8bd-93b0-4ed7-83f6-e99333a8d7de', 488, 1556),
	('0aa1dc8f-7f43-438f-ae19-07cb26b740cd', 166, 1722),
	('16d0d069-1cdf-4dc2-b495-97a93d5c70bb', 491, 788),
	('65588ac8-e153-4aec-a328-9220ce45be84', 155, 943),
	('1a6b66f9-430c-411c-85d3-49a1c5ab8cec', 395, 1196),
	('472ffff3-8108-46fc-b1b2-d8f0c0ae48a4', 471, 2193),
	('8ec46b0b-1511-4559-98c4-354ede3e8a31', 140, 2333),
	('6c95e56f-51ea-4e8d-8507-541e07d13f48', 430, 2055),
	('067219dc-8c31-4c5d-b55f-9e01673f956f', 95, 2182),
	('589fb973-ff8a-4606-a2cf-75eef3642090', 453, 652),
	('9b71dbbc-ff18-4641-9dec-96ea553a411d', 31, 2086),
	('19ffcea7-3fd0-4e50-826d-e3b28e414549', 105, 2191),
	('b1384ff2-18c7-4f64-b02a-39ef0cb47975', 79, 751),
	('12fe08c5-965a-4bb8-ac27-8e1debe35d3c', 486, 2668),
	('4d3f8e39-037a-4766-975f-0179d4a10e14', -1945, 388),
	('5050872c-771b-4c6f-ae45-b926452c5254', -838, 345),
	('f5beb5eb-86cf-4a5f-a9ab-44cf66220669', 462, 1114),
	('aaabe1bd-861d-4e16-a7d0-fb66135d53ab', 480, 1676),
	('04580cd9-55d1-4880-a02c-284ba4be9dff', 295, 1420),
	('cf48915e-ccc6-452a-8e93-2b51e91c2617', -1158, 262),
	('ac6d64e7-fed5-4658-9e02-a48620472edd', 259, 934),
	('ec0d2569-2a77-442d-abc5-21db89cfd6e2', 493, 2684),
	('9866c04b-91b6-4a55-aeda-dd80a1b1406b', 374, 1308),
	('0992399e-e69f-4397-bf5a-2dd2feea7585', 457, 1571),
	('557e6f67-c811-4e7e-9a52-7182721caed3', 142, 375),
	('41fb841e-a5d8-4809-b5b9-f5f015bd1029', 27, 289),
	('e07ab7bf-1289-4c76-b691-fb525a147cde', 494, 1802),
	('9d952e32-d77f-41c5-b4e2-70ff62d7a48c', 496, 2172),
	('81400ccf-64a7-4ba9-b1b2-e28e22d839a0', -454, 1718),
	('41099ad1-3106-47f4-aaf8-ecbad8b7dc52', 186, 937),
	('793547d4-de42-4d40-a1df-bfee07fd0551', 122, 1840),
	('9775dd8e-6666-44dd-aaca-3b107ae39bf9', 446, 791),
	('642bdd5f-8be4-48d5-b70c-5e3f091d0358', 64, 855),
	('53e6da12-7324-48c3-a780-6a4f1f4503b1', -2240, 428),
	('b69ac09b-318c-4c99-a8f7-d5d1097dedc6', 499, 1442),
	('34eb1c64-f8ac-4c0b-9f85-9d9b5f4e8ce5', 29, 318),
	('0eefcba0-3825-4277-b9ad-65bb547b0462', -1237, 603)

update Users
set Balance = 428
where UserId = 'dad5fc12-17f4-4ba0-aaf4-840d0dbb0ca6'


update Users
set Balance = 318
where UserId = '8f2c75b6-c33e-4ebd-9b98-a1680a2b2fcd'


update Users
set Balance = 388
where UserId = 'e696370a-69b8-4742-a6c6-2f33057bf5d5'


update Users
set Balance = 1442
where UserId = '84467d5d-843b-41f3-8146-fd76e298587b'


update Users
set Balance = 1571
where UserId = '6bd97b1f-af97-4027-ae59-078c99436c11'


update Users
set Balance = 1802
where UserId = 'f08f6a44-b2da-4ee4-a58c-439d7bb610e5'


update Users
set Balance = 937
where UserId = '7b682342-651c-47d8-bdc5-d8c0fb34ee36'


update Users
set Balance = 2684
where UserId = '1b6c06ce-1d7b-4090-971c-6d52c145cac8'


update Users
set Balance = 855
where UserId = 'e73d2348-c324-41bf-bd94-abc5a4b43529'


update Users
set Balance = 603
where UserId = 'c108add8-c40d-4fb5-8d7b-f948091856b2'


update Users
set Balance = 375
where UserId = '730d03a2-c4b3-4be3-ac3b-57f1acb5ea3d'


update Users
set Balance = 563
where UserId = '2eb19b63-0d57-4201-b8f6-15a2bb9ebc9a'

update Profiles
set
	Department = 'Application Developer',
	Mbti = 'ITSJ',
	Zodiac = 'Leo',
	FavoriteFood = 'miso soup',
	FunFact = 'avoid spicy foods;love animals;part-time gamer'
where
	UserId = 'c108add8-c40d-4fb5-8d7b-f948091856b2'