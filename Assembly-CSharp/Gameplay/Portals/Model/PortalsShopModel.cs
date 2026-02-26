using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Portal;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005D3 RID: 1491
	[Token(Token = "0x20005D3")]
	public class PortalsShopModel : AbstractModel
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006C1")]
		public IGame Game
		{
			[Token(Token = "0x60023E5")]
			[Address(RVA = "0x7537", Offset = "0x7537", VA = "0x7537")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006C2")]
		public PortalsModel PortalsModel
		{
			[Token(Token = "0x60023E6")]
			[Address(RVA = "0x7538", Offset = "0x7538", VA = "0x7538")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x7539", Offset = "0x7539", VA = "0x7539")]
		public PortalsShopModel(UserData user, IGame game, PortalsModel portalsModel)
		{
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006C3")]
		public List<ShopItemData> ShopItems
		{
			[Token(Token = "0x60023E8")]
			[Address(RVA = "0x753A", Offset = "0x753A", VA = "0x753A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x170006C4")]
		public ArtikulTypeFilters.Types.FilterType FilterType
		{
			[Token(Token = "0x60023E9")]
			[Address(RVA = "0x753B", Offset = "0x753B", VA = "0x753B")]
			get
			{
				return ArtikulTypeFilters.Types.FilterType.UnknownFilterType;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006C5")]
		public Dictionary<uint, ArtikulTypeFilters> AllFilters
		{
			[Token(Token = "0x60023EA")]
			[Address(RVA = "0x753C", Offset = "0x753C", VA = "0x753C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023EC RID: 9196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C6")]
		public IList<ArtikulTypeFilters> AvailableFilters
		{
			[Token(Token = "0x60023EB")]
			[Address(RVA = "0x753D", Offset = "0x753D", VA = "0x753D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023EC")]
			[Address(RVA = "0x753E", Offset = "0x753E", VA = "0x753E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x1BDA", Offset = "0x1BDA", VA = "0x1BDA")]
		public void AddShopItem(ArtifactItem item)
		{
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x753F", Offset = "0x753F", VA = "0x753F")]
		private ArtifactData CreateArtifactData(ArtifactDetails artifactDetails)
		{
		/* --- GHIDRA: CreateArtifactData ---
		void Gameplay_Portals_Model_PortalsShopModel__CreateArtifactData(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58137 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo);
		    DAT_ram_00a58137 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x040013CC RID: 5068
		[Token(Token = "0x40013CC")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, ArtikulTypeFilters> _allFilters;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PortalsModel ---
		void Gameplay_Portals_Model_PortalsShopModel__get_PortalsModel
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58133 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItemData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ShopItemData__TypeInfo);
		    DAT_ram_00a58133 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ShopItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ShopItemData___ctor__);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  return;
		}
		*/


		/* --- GHIDRA: get_FilterType ---
		int Gameplay_Portals_Model_PortalsShopModel__get_FilterType(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  undefined4 *puVar5;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58134 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_ArtikulTypeFilters__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeFilters__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Model_PortalsShopModel___c__get_AllFilters_b__14_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo);
		    DAT_ram_00a58134 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x18);
		  if (iVar4 == 0) {
		    uVar1 = 0;
		    param1_00 = *(int **)(param1 + 0xc);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		          goto code_r0x80ea7354;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ea7354:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    uVar3 = Core_Extensions_Dict_DictExt__GetGameFiledGems(uVar3,0x20,0);
		    if (*(int *)(Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo);
		    }
		    puVar5 = *(undefined4 **)(Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo + 0x5c);
		    iVar4 = puVar5[1];
		    if (iVar4 == 0) {
		      if (*(int *)(Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo);
		        puVar5 = *(undefined4 **)(Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar5;
		      iVar4 = unnamed_function_1417(System_Func_ArtikulTypeFilters__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar4,param2_00,
		                 Method_Gameplay_Portals_Model_PortalsShopModel___c__get_AllFilters_b__14_0__,0);
		      *(int *)(*(int *)(Gameplay_Portals_Model_PortalsShopModel___c_TypeInfo + 0x5c) + 4) = iVar4;
		    }
		    iVar4 = System_Linq_Enumerable__ToDictionary_object__object_
		                      (uVar3,iVar4,
		                       Method_System_Linq_Enumerable_ToDictionary_ArtikulTypeFilters__uint___);
		    *(int *)(param1 + 0x18) = iVar4;
		  }
		  return iVar4;
		}
		*/


		/* --- GHIDRA: set_AvailableFilters ---
		int Gameplay_Portals_Model_PortalsShopModel__set_AvailableFilters
		              (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param3_00;
		  int *piVar6;
		  
		  if (DAT_ram_00a58136 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtifactInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a58136 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_ArtifactInfo_TypeInfo);
		  Protocol_Common_ArtifactInfo__pb__Google_Protobuf_IMessage_get_Descriptor(iVar2,0);
		  iVar3 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(double *)(iVar3 + 0x28) = (double)*(ulonglong *)(param2 + 0x28);
		  *(int *)(iVar2 + 0x24) = iVar3;
		  *(undefined4 *)(iVar2 + 0x18) = *(undefined4 *)(param2 + 0x18);
		  *(undefined4 *)(iVar2 + 0x20) = *(undefined4 *)(param2 + 0x20);
		  *(undefined8 *)(iVar2 + 0x10) = *(undefined8 *)(param2 + 0x10);
		  Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		            (*(undefined4 *)(iVar2 + 0x1c),*(undefined4 *)(param2 + 0x1c),
		             Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		  piVar6 = *(int **)(param1 + 0xc);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		        goto code_r0x80ea75ce;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ea75ce:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  piVar6 = *(int **)(param1 + 0xc);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x80ea7659;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ea7659:
		  uVar1 = 0;
		  param3_00 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar2 = Core_Data_ArtifactData__IsGuideTarget(iVar2,uVar5,param3_00,0);
		  piVar6 = *(int **)(param1 + 0xc);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		        goto code_r0x80ea76e8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ea76e8:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  *(undefined4 *)(iVar2 + 0x80) = 7;
		  *(undefined4 *)(iVar2 + 0x70) = uVar5;
		  return iVar2;
		}
		*/

}
