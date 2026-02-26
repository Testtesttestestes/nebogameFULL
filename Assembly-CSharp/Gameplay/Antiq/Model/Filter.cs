using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D92 RID: 3474
	[Token(Token = "0x2000D92")]
	internal class Filter
	{
		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060054F7 RID: 21751 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060054F8 RID: 21752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700114C")]
		public CategoryData Category
		{
			[Token(Token = "0x60054F7")]
			[Address(RVA = "0xA29D", Offset = "0xA29D", VA = "0xA29D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054F8")]
			[Address(RVA = "0xA29E", Offset = "0xA29E", VA = "0xA29E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x060054F9 RID: 21753 RVA: 0x0000F588 File Offset: 0x0000D788
		// (set) Token: 0x060054FA RID: 21754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700114D")]
		public bool IsShowOnlyReceived
		{
			[Token(Token = "0x60054F9")]
			[Address(RVA = "0xA29F", Offset = "0xA29F", VA = "0xA29F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60054FA")]
			[Address(RVA = "0xA2A0", Offset = "0xA2A0", VA = "0xA2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060054FC RID: 21756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700114E")]
		public string CurrentSearchPhrase
		{
			[Token(Token = "0x60054FB")]
			[Address(RVA = "0xA2A1", Offset = "0xA2A1", VA = "0xA2A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054FC")]
			[Address(RVA = "0xA2A2", Offset = "0xA2A2", VA = "0xA2A2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054FD")]
		[Address(RVA = "0xA2A3", Offset = "0xA2A3", VA = "0xA2A3")]
		public Filter(CategoryData defaultCategory)
		{
		/* --- GHIDRA: <Apply>b__14_2 ---
		void Gameplay_Antiq_Model_Filter___Apply_b__14_2(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a587f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Model_Filter___c_TypeInfo);
		    DAT_ram_00a587f9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Antiq_Model_Filter___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Antiq_Model_Filter___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <Apply>b__14_1 ---
		undefined4 Gameplay_Antiq_Model_Filter___Apply_b__14_1(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  uVar1 = 1;
		  uVar2 = Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetImageThumbnailAssetId
		                    (*(undefined4 *)(param2 + 0xc),0);
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar2,0);
		  if ((iVar3 == 0) &&
		     (iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (*(undefined4 *)(param1 + 0x14),0), iVar3 == 0)) {
		    uVar1 = Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetImageThumbnailAssetId
		                      (*(undefined4 *)(param2 + 0xc),0);
		    uVar1 = func_ii_7775(uVar1,0);
		    uVar2 = func_ii_7775(*(undefined4 *)(param1 + 0x14),0);
		    uVar1 = func_ii_7903(uVar1,uVar2,0);
		  }
		  return uVar1;
		}
		*/

		/* --- GHIDRA: <Apply>b__14_0 ---
		uint Gameplay_Antiq_Model_Filter___Apply_b__14_0(int param1,undefined4 param2,undefined4 param3)
		
		{
		  char cVar1;
		  uint uVar2;
		  
		  cVar1 = *(char *)(param1 + 0x10);
		  uVar2 = Gameplay_Antiq_Model_GroupData__GetLevel(param2,0);
		  if ((cVar1 != '\0') == uVar2) {
		    uVar2 = 1;
		  }
		  else {
		    uVar2 = (uint)(*(char *)(param1 + 0x10) == '\0');
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: .ctor ---
		uint Gameplay_Antiq_Model_Filter___ctor(int param1,int param2,undefined4 param3)
		
		{
		  if (*(int *)(param2 + 0x10) != *(int *)(param1 + 0xc)) {
		    return (uint)(*(int *)(param1 + 0xc) == *(int *)(param1 + 8));
		  }
		  return 1;
		}
		*/

		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x1D24", Offset = "0x1D24", VA = "0x1D24")]
		public IList<GroupData> Apply(IList<GroupData> items, out int currentCount, out int totalCount)
		{
		/* --- GHIDRA: Apply ---
		void Gameplay_Antiq_Model_Filter__Apply(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a59494 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GroupData__ResetItems__);
		    DAT_ram_00a59494 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (param1[0x2c],param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GroupData__ResetItems__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x8")]
		public readonly CategoryData DefaultCategory;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ReturnType ---
		void MS_Internal_Xml_XPath_Filter__get_ReturnType
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a51a7f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AstNode___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AstNode__TypeInfo);
		    DAT_ram_00a51a7f = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AstNode__TypeInfo);
		  Sirenix_Utilities_LinqExtensions__Convert_object_
		            (param1_00,param3,Method_System_Collections_Generic_List_AstNode___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

}
