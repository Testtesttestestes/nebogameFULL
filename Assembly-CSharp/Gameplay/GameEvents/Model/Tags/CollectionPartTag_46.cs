using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	public class CollectionPartTag_46 : AbstractTag
	{
		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x170008F1")]
		public uint MedalId
		{
			[Token(Token = "0x6002E57")]
			[Address(RVA = "0x7ED2", Offset = "0x7ED2", VA = "0x7ED2")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x6002E58")]
		[Address(RVA = "0x7ED3", Offset = "0x7ED3", VA = "0x7ED3", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E59")]
		[Address(RVA = "0x7ED4", Offset = "0x7ED4", VA = "0x7ED4")]
		public CollectionPartTag_46()
		{
		}

		// Token: 0x0400196C RID: 6508
		[Token(Token = "0x400196C")]
		public const string COLLECTION_PART_VIEW = "collection_part_view";

		// Token: 0x0400196D RID: 6509
		[Token(Token = "0x400196D")]
		public const string APPR_SMALL_VIEW_PREFAB = "AprSmallTagView";

		// Token: 0x0400196E RID: 6510
		[Token(Token = "0x400196E")]
		public const string MEDAL_VIEW_PREFAB = "MedalTagView";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MedalId ---
		int Gameplay_GameEvents_Model_Tags_CollectionPartTag_46__get_MedalId
		              (int *param1,undefined4 param2,int param3,undefined4 *param4,int param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param4_00;
		  int *param1_00;
		  undefined4 param1_01;
		  double dVar5;
		  uint uVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_AprSmallTagView___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_MedalTagView___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3189);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10936);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21407);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574d1 = '\x01';
		  }
		  local_4 = 0;
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 == 0) {
		    *param4 = 0;
		  }
		  else {
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar1;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21407,0);
		    if (iVar3 != 0) {
		      *param4 = StringLiteral_5;
		      param1_00 = (int *)param1[2];
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar6 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0xd8);
		            goto code_r0x80d93f28;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x80d93f28:
		      iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		      dVar5 = *(double *)(param1[5] + 0x10);
		      if (dVar5 < 4294967296.0 && 0.0 <= dVar5) {
		        iVar7 = (int)dVar5;
		      }
		      else {
		        iVar7 = 0;
		      }
		      if (ABS(dVar5) < 2147483648.0) {
		        iVar8 = (int)dVar5;
		      }
		      else {
		        iVar8 = -0x80000000;
		      }
		      if (0.0 <= dVar5) {
		        iVar8 = iVar7;
		      }
		      iVar3 = func_ii_7730(*(undefined4 *)(iVar3 + 0xc),iVar8,
		                           Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		                          );
		      param1_01 = *(undefined4 *)(iVar3 + 0x10);
		      iVar7 = param1[2];
		      uVar1 = func_ii_6965(*(undefined4 *)(*(int *)(param3 + 0x18) + 8),0);
		      param4_00 = Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__uint___GetWrapper
		                            (*(undefined4 *)(*(int *)(param3 + 0x18) + 8),0);
		      iVar7 = Core_Extensions_Dict_MedalDicExt__GetDescription
		                        (param1_01,iVar7,uVar1,param4_00,&local_4,0);
		      if (iVar7 == 0) {
		        iVar7 = Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                          (param1,StringLiteral_10936,*(undefined4 *)(param5 + 8),
		                           Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_MedalTagView___
		                          );
		        iVar8 = **(int **)(iVar7 + 0x10);
		        (**(code **)((ulonglong)*(uint *)(iVar8 + 0x138) * 4))
		                  (*(int **)(iVar7 + 0x10),iVar3,*(undefined4 *)(iVar8 + 0x13c));
		        Gameplay_Medals_View_MedalView__get_Achieved(*(undefined4 *)(iVar7 + 0x10),1,0);
		      }
		      else {
		        iVar3 = Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                          (param1,StringLiteral_3189,*(undefined4 *)(param5 + 8),
		                           Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_AprSmallTagView___
		                          );
		        iVar7 = **(int **)(iVar3 + 0x10);
		        (**(code **)((ulonglong)*(uint *)(iVar7 + 0x138) * 4))
		                  (*(int **)(iVar3 + 0x10),local_4,*(undefined4 *)(iVar7 + 0x13c));
		      }
		    }
		  }
		  return iVar2;
		}
		*/

}
