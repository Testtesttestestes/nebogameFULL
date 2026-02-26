using System;
using System.Runtime.CompilerServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[CreateAssetMenu(fileName = "AppBuildInfoEditor", menuName = "Heavens/App build info for editor")]
	public class AppBuildInfo : ScriptableObject
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00002850 File Offset: 0x00000A50
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public int AppBuildNumber
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x56B8", Offset = "0x56B8", VA = "0x56B8")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x56B9", Offset = "0x56B9", VA = "0x56B9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000056")]
		public string AppVersionExtraInfo
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x56BA", Offset = "0x56BA", VA = "0x56BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public string BuildTarget
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x56BB", Offset = "0x56BB", VA = "0x56BB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x56BC", Offset = "0x56BC", VA = "0x56BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x17000058")]
		public Core.Version Version
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x56BD", Offset = "0x56BD", VA = "0x56BD")]
			get
			{
				return default(Core.Version);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x56BE", Offset = "0x56BE", VA = "0x56BE")]
		public void SetAppBuildNumber(int value)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x56BF", Offset = "0x56BF", VA = "0x56BF")]
		public void SetAppVersionExtraInfo(string value)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x56C0", Offset = "0x56C0", VA = "0x56C0")]
		public void SetBuildTarget(string value)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x56C1", Offset = "0x56C1", VA = "0x56C1")]
		public void SetVersion(Core.Version value)
		{
		/* --- GHIDRA: SetVersion ---
		undefined4 Utils_AppBuildInfo__SetVersion(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  undefined8 uVar6;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a648d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AppBuildInfo_Element__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AppBuildInfo_Element__ToArray__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AppBuildInfo_Element___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AppBuildInfo_Element__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24476);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17400);
		    DAT_ram_00a648d7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AppBuildInfo_Element__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_AppBuildInfo_Element___ctor__);
		  local_10 = *(undefined8 *)(param1 + 0x18);
		  local_18 = *(undefined8 *)(param1 + 0x10);
		  uVar2 = Core_Version___ctor(&local_18,0);
		  uVar4 = StringLiteral_17400;
		  iVar1 = Method_System_Collections_Generic_List_AppBuildInfo_Element__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar6 = CONCAT44(uVar2,uVar4);
		  uVar5 = *(uint *)(param1_00 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		    *(undefined8 *)(*(int *)(param1_00 + 8) + uVar5 * 8 + 0x10) = uVar6;
		  }
		  else {
		    local_20 = uVar6;
		    local_8 = uVar6;
		    Core_Data_CollectionData__get_CollectionId
		              (param1_00,&local_20,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0xc),0);
		  uVar4 = StringLiteral_24476;
		  iVar1 = Method_System_Collections_Generic_List_AppBuildInfo_Element__Add__;
		  if (iVar3 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0xc);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar6 = CONCAT44(uVar2,uVar4);
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined8 *)(*(int *)(param1_00 + 8) + uVar5 * 8 + 0x10) = uVar6;
		    }
		    else {
		      local_28 = uVar6;
		      local_8 = uVar6;
		      Core_Data_CollectionData__get_CollectionId
		                (param1_00,&local_28,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                );
		    }
		  }
		  uVar4 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (param1_00,
		                     Method_System_Collections_Generic_List_AppBuildInfo_Element__ToArray__);
		  return uVar4;
		}
		*/

		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x56C2", Offset = "0x56C2", VA = "0x56C2")]
		public AppBuildInfo.Element[] GetValues()
		{
		/* --- GHIDRA: GetValues ---
		undefined4 Utils_AppBuildInfo__GetValues(undefined4 param1)
		
		{
		  if (DAT_ram_00a648d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3167);
		    DAT_ram_00a648d8 = '\x01';
		  }
		  return StringLiteral_3167;
		}
		*/

			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x56C3", Offset = "0x56C3", VA = "0x56C3")]
		public static string GetDefaultText()
		{
		/* --- GHIDRA: GetDefaultText ---
		undefined4 Utils_AppBuildInfo__GetDefaultText(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a648d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_String_Join_AppBuildInfo_Element___);
		    DAT_ram_00a648d9 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = Utils_AppBuildInfo__SetVersion(param1,param1);
		  uVar1 = System_String__Join___Il2CppFullySharedGenericType_
		                    (param1_00,uVar1,Method_System_String_Join_AppBuildInfo_Element___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x56C4", Offset = "0x56C4", VA = "0x56C4", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Utils_AppBuildInfo__ToString(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a648da == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_514);
		    DAT_ram_00a648da = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x20) = StringLiteral_514;
		  UnityEngine_RuntimeInitializeOnLoadMethodAttribute__set_loadType(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x56C5", Offset = "0x56C5", VA = "0x56C5")]
		public AppBuildInfo()
		{
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private string _appVersionExtraInfo;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Core.Version _version;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _separator;

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		public readonly struct Element
		{
			// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x56C6", Offset = "0x56C6", VA = "0x56C6")]
			public Element(string name, string value)
			{
			}

			// Token: 0x0600021D RID: 541 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x4BBD", Offset = "0x4BBD", VA = "0x4BBD", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			[FieldOffset(Offset = "0x0")]
			private readonly string _name;

			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x4")]
			private readonly string _value;
		}
	}
}
