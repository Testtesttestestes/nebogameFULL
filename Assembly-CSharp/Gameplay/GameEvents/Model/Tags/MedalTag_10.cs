using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AC RID: 1964
	[Token(Token = "0x20007AC")]
	public class MedalTag_10 : AbstractTag
	{
		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002E89 RID: 11913 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x17000905")]
		public uint MedalId
		{
			[Token(Token = "0x6002E89")]
			[Address(RVA = "0x7F04", Offset = "0x7F04", VA = "0x7F04")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x6002E8A")]
		[Address(RVA = "0x7F05", Offset = "0x7F05", VA = "0x7F05", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E8B")]
		[Address(RVA = "0x7F06", Offset = "0x7F06", VA = "0x7F06")]
		public MedalTag_10()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_GameEvents_Model_Tags_MedalTag_10___ctor(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  
		  dVar1 = *(double *)(*(int *)(param1 + 0x14) + 0x10);
		  if (2147483648.0 <= ABS(dVar1)) {
		    return 0x80000000;
		  }
		  return (int)dVar1;
		}
		*/

		}

		// Token: 0x0400197E RID: 6526
		[Token(Token = "0x400197E")]
		public const string MEDAl_TITLE = "medal_title";

		// Token: 0x0400197F RID: 6527
		[Token(Token = "0x400197F")]
		public const string MEDAl_RANK = "medal_rank";

		// Token: 0x04001980 RID: 6528
		[Token(Token = "0x4001980")]
		public const string MEDAl_VIEW = "medal_view";

		// Token: 0x04001981 RID: 6529
		[Token(Token = "0x4001981")]
		public const string MEDAL_VIEW_PREFAB = "MedalTagView";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MedalId ---
		int Gameplay_GameEvents_Model_Tags_MedalTag_10__get_MedalId
		              (int *param1,undefined4 param2,undefined4 param3,int *param4,int param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  int *piVar5;
		  double dVar6;
		  uint uVar7;
		  int param2_00;
		  int iVar8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_MedalTagView___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25333);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25335);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10936);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25332);
		    DAT_ram_00a574de = '\x01';
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
		    iVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = iVar3;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25333,0);
		    if (iVar3 == 0) {
		      iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25332,0);
		      if (iVar3 == 0) {
		        iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25335,0);
		        if (iVar3 != 0) {
		          *param4 = StringLiteral_5;
		          piVar5 = (int *)param1[2];
		          iVar3 = *piVar5;
		          if (*(ushort *)(iVar3 + 0xb6) != 0) {
		            uVar7 = 0;
		            do {
		              if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8))
		              {
		                puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 +
		                                 0xd8);
		                goto code_r0x80d965dd;
		              }
		              uVar7 = uVar7 + 1;
		            } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x80d965dd:
		          iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		          dVar6 = *(double *)(param1[5] + 0x10);
		          if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		            iVar8 = (int)dVar6;
		          }
		          else {
		            iVar8 = 0;
		          }
		          if (ABS(dVar6) < 2147483648.0) {
		            param2_00 = (int)dVar6;
		          }
		          else {
		            param2_00 = -0x80000000;
		          }
		          if (0.0 <= dVar6) {
		            param2_00 = iVar8;
		          }
		          uVar1 = func_ii_7730(*(undefined4 *)(iVar3 + 0xc),param2_00,
		                               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		                              );
		          iVar3 = Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                            (param1,StringLiteral_10936,*(undefined4 *)(param5 + 8),
		                             Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_MedalTagView___
		                            );
		          iVar8 = **(int **)(iVar3 + 0x10);
		          (**(code **)((ulonglong)*(uint *)(iVar8 + 0x138) * 4))
		                    (*(int **)(iVar3 + 0x10),uVar1,*(undefined4 *)(iVar8 + 0x13c));
		          Gameplay_Medals_View_MedalView__get_Achieved(*(undefined4 *)(iVar3 + 0x10),1,0);
		        }
		      }
		      else {
		        uVar7 = 0;
		        piVar5 = (int *)param1[2];
		        iVar3 = *piVar5;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 0xd0)
		              ;
		              goto code_r0x80d964f5;
		            }
		            uVar7 = uVar7 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d964f5:
		        uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		        dVar6 = *(double *)(param1[5] + 0x10);
		        if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		          iVar3 = (int)dVar6;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar6) < 2147483648.0) {
		          iVar8 = (int)dVar6;
		        }
		        else {
		          iVar8 = -0x80000000;
		        }
		        if (0.0 <= dVar6) {
		          iVar8 = iVar3;
		        }
		        iVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                          (uVar1,iVar8,0);
		        local_4 = *(undefined4 *)(iVar3 + 0x20);
		        iVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		        if (iVar3 == 0) {
		          iVar3 = StringLiteral_5;
		        }
		        *param4 = iVar3;
		      }
		    }
		    else {
		      piVar5 = (int *)param1[2];
		      iVar3 = *piVar5;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d963f9;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d963f9:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      dVar6 = *(double *)(param1[5] + 0x10);
		      if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		        iVar3 = (int)dVar6;
		      }
		      else {
		        iVar3 = 0;
		      }
		      if (ABS(dVar6) < 2147483648.0) {
		        iVar8 = (int)dVar6;
		      }
		      else {
		        iVar8 = -0x80000000;
		      }
		      if (0.0 <= dVar6) {
		        iVar8 = iVar3;
		      }
		      uVar1 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                        (uVar1,iVar8,0);
		      iVar3 = func_ii_14054(uVar1,0);
		      *param4 = iVar3;
		    }
		  }
		  return iVar2;
		}
		*/

}
