using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Utils
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Serializable]
	public class LocalProps
	{
		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x4472", Offset = "0x4472", VA = "0x4472")]
		public LocalProps(string storageName, string defaultVersion)
		{
		/* --- GHIDRA: .ctor ---
		int Utils_LocalProps___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a627e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Newtonsoft_Json_JsonConvert_DeserializeObject_List_LocalProps_Data____);
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_JsonConvert_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LocalProps_Data__AddRange__);
		    DAT_ram_00a627e8 = '\x01';
		  }
		  uVar1 = UnityEngine_PlayerPrefs__GetInt(*(undefined4 *)(param1 + 0xc),0);
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar1,0);
		  if (iVar2 == 0) {
		    if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		    }
		    uVar1 = func_ii_14092(uVar1,
		                          Method_Newtonsoft_Json_JsonConvert_DeserializeObject_List_LocalProps_Data____
		                         );
		    func_ii_6335(*(undefined4 *)(param1 + 8),uVar1,
		                 Method_System_Collections_Generic_List_LocalProps_Data__AddRange__);
		  }
		  return param1;
		}
		*/

		}

		// Token: 0x0600024E RID: 590 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x56F0", Offset = "0x56F0", VA = "0x56F0")]
		private bool TryGetProp(string scope, string name, out LocalProps.Data data, [CanBeNull] [Optional] string version)
		{
		/* --- GHIDRA: TryGetProp ---
		void Utils_LocalProps__TryGetProp
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined8 *param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  param1_00 = 0;
		  *param4 = 0;
		  local_4 = 0;
		  iVar1 = Utils_JWT_JWTContent___ctor(param1,param2,param3,&local_4,param5,auStack_10);
		  if (local_4 != 0) {
		    param1_00 = *(undefined4 *)(local_4 + 0x14);
		  }
		  if ((iVar1 != 0) &&
		     (iVar1 = System_Collections_Specialized_NameValueCollection__get_Item(param1_00,param4,0),
		     iVar1 != 0)) {
		    *param4 = 0;
		  }
		  Utils_LocalProps__TryGetProp(param1,param2,param3,*param4,param5,auStack_10);
		  return;
		}
		*/

		/* --- GHIDRA: TryGetProp ---
		void Utils_LocalProps__TryGetProp
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined8 *param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  param1_00 = 0;
		  *param4 = 0;
		  local_4 = 0;
		  iVar1 = Utils_JWT_JWTContent___ctor(param1,param2,param3,&local_4,param5,auStack_10);
		  if (local_4 != 0) {
		    param1_00 = *(undefined4 *)(local_4 + 0x14);
		  }
		  if ((iVar1 != 0) &&
		     (iVar1 = System_Collections_Specialized_NameValueCollection__get_Item(param1_00,param4,0),
		     iVar1 != 0)) {
		    *param4 = 0;
		  }
		  Utils_LocalProps__TryGetProp(param1,param2,param3,*param4,param5,auStack_10);
		  return;
		}
		*/

		/* --- GHIDRA: TryGetProp ---
		void Utils_LocalProps__TryGetProp
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined8 *param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  param1_00 = 0;
		  *param4 = 0;
		  local_4 = 0;
		  iVar1 = Utils_JWT_JWTContent___ctor(param1,param2,param3,&local_4,param5,auStack_10);
		  if (local_4 != 0) {
		    param1_00 = *(undefined4 *)(local_4 + 0x14);
		  }
		  if ((iVar1 != 0) &&
		     (iVar1 = System_Collections_Specialized_NameValueCollection__get_Item(param1_00,param4,0),
		     iVar1 != 0)) {
		    *param4 = 0;
		  }
		  Utils_LocalProps__TryGetProp(param1,param2,param3,*param4,param5,auStack_10);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1D82", Offset = "0x1D82", VA = "0x1D82")]
		public LocalProps SetProp(string scope, string name, string value, [CanBeNull] [Optional] string version)
		{
		/* --- GHIDRA: SetProp ---
		int * Utils_LocalProps__SetProp(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xd8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xdc));
		  func_ii_7893(param1[3],param2_00,0);
		  func_ii_10838(0);
		  return param1;
		}
		*/

		/* --- GHIDRA: SetProp ---
		int * Utils_LocalProps__SetProp(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xd8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xdc));
		  func_ii_7893(param1[3],param2_00,0);
		  func_ii_10838(0);
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x56F1", Offset = "0x56F1", VA = "0x56F1")]
		public LocalProps SetProp(string scope, string name, long value, [CanBeNull] [Optional] string version)
		{
			return null;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1D7C", Offset = "0x1D7C", VA = "0x1D7C")]
		public bool TryGetProp(string scope, string name, out string value, [CanBeNull] [Optional] string version)
		{
			return default(bool);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x56F2", Offset = "0x56F2", VA = "0x56F2")]
		public bool TryGetProp(string scope, string name, out long value, [CanBeNull] [Optional] string version)
		{
			return default(bool);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x56F3", Offset = "0x56F3", VA = "0x56F3")]
		public void GetOrCreate(string scope, string name, out long value, [CanBeNull] [Optional] string version)
		{
		/* --- GHIDRA: GetOrCreate ---
		int Utils_LocalProps__GetOrCreate
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a627e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LocalProps_Data__Remove__);
		    DAT_ram_00a627e6 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Utils_JWT_JWTContent___ctor(param1,param2,param3,&local_4,param4,auStack_10);
		  if (iVar1 != 0) {
		    func_ii_4876(*(undefined4 *)(param1 + 8),local_4,
		                 Method_System_Collections_Generic_List_LocalProps_Data__Remove__);
		  }
		  return param1;
		}
		*/

		/* --- GHIDRA: GetOrCreate ---
		int Utils_LocalProps__GetOrCreate
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a627e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LocalProps_Data__Remove__);
		    DAT_ram_00a627e6 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Utils_JWT_JWTContent___ctor(param1,param2,param3,&local_4,param4,auStack_10);
		  if (iVar1 != 0) {
		    func_ii_4876(*(undefined4 *)(param1 + 8),local_4,
		                 Method_System_Collections_Generic_List_LocalProps_Data__Remove__);
		  }
		  return param1;
		}
		*/

		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x56F4", Offset = "0x56F4", VA = "0x56F4")]
		public string GetOrCreate(string scope, string name, out string value, [CanBeNull] [Optional] string version)
		{
			return null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x56F5", Offset = "0x56F5", VA = "0x56F5")]
		public LocalProps Remove(string scope, string name, [CanBeNull] [Optional] string version)
		{
		/* --- GHIDRA: Remove ---
		undefined4 Utils_LocalProps__Remove(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a627e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_JsonConvert_TypeInfo);
		    DAT_ram_00a627e9 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 8);
		  if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		  }
		  uVar1 = Newtonsoft_Json_JsonConvert__ToString(uVar1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x4474", Offset = "0x4474", VA = "0x4474")]
		public LocalProps Reset()
		{
		/* --- GHIDRA: Reset ---
		undefined8 Utils_LocalProps__Reset(undefined4 param1)
		
		{
		  undefined8 uVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62827 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a62827 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  uVar1 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1D83", Offset = "0x1D83", VA = "0x1D83")]
		public LocalProps Commit()
		{
		/* --- GHIDRA: Commit ---
		void Utils_LocalProps__Commit(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a589d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a589d6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80f5a4a5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f5a4a5:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = Core_Gameplay_Managers_DictManager__CheckSupportedService(uVar3,param2,0);
		  if (iVar4 != 0) {
		    if (*(int *)(iVar4 + 0x10) == 1) {
		      uVar3 = *(undefined4 *)(iVar4 + 0x14);
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager___cctor(uVar3,0,0,1,0);
		      return;
		    }
		    if (*(int *)(iVar4 + 0x10) == 2) {
		      uVar3 = *(undefined4 *)(iVar4 + 0x14);
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager__ReleaseTextMeshProSpriteAsset(uVar3,0,0,1,0);
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x4473", Offset = "0x4473", VA = "0x4473")]
		public LocalProps Load()
		{
		/* --- GHIDRA: Load ---
		int Utils_LocalProps__Load(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a627e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LocalProps_Data__Clear__);
		    DAT_ram_00a627e7 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x56F6", Offset = "0x56F6", VA = "0x56F6", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly List<LocalProps.Data> _data;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly string StorageName;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string DefaultVersion;

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		public enum Scopes
		{
			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			User,
			// Token: 0x04000104 RID: 260
			[Token(Token = "0x4000104")]
			OneOnOneCombat,
			// Token: 0x04000105 RID: 261
			[Token(Token = "0x4000105")]
			Application
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		public enum Names
		{
			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			ReceivedNewUserLevelForNotify,
			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			IsShowUserSkills,
			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			IsShowNYSnowFx,
			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			IsShowNYWindy,
			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			PreloaderSkinJson
		}

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		[Serializable]
		private class Data
		{
			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600025A RID: 602 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700005E")]
			[JsonProperty("scope")]
			public string Scope
			{
				[Token(Token = "0x600025A")]
				[Address(RVA = "0x56F7", Offset = "0x56F7", VA = "0x56F7")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600025B RID: 603 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700005F")]
			[JsonProperty("name")]
			public string Name
			{
				[Token(Token = "0x600025B")]
				[Address(RVA = "0x56F8", Offset = "0x56F8", VA = "0x56F8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600025C RID: 604 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000060")]
			[JsonProperty("version")]
			public string Version
			{
				[Token(Token = "0x600025C")]
				[Address(RVA = "0x56F9", Offset = "0x56F9", VA = "0x56F9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600025D RID: 605 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000061")]
			public string Value
			{
				[Token(Token = "0x600025D")]
				[Address(RVA = "0x56FA", Offset = "0x56FA", VA = "0x56FA")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600025E")]
				[Address(RVA = "0x56FB", Offset = "0x56FB", VA = "0x56FB")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x56FC", Offset = "0x56FC", VA = "0x56FC")]
			public Data(string scope, string name, string value, string version)
			{
			}

			// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x56FD", Offset = "0x56FD", VA = "0x56FD")]
			public void SetValue(string value)
			{
			}

			// Token: 0x06000261 RID: 609 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x56FE", Offset = "0x56FE", VA = "0x56FE", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}
	}
}
