using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079A RID: 1946
	[Token(Token = "0x200079A")]
	public class BossInstanceTypeTag_34 : AbstractTag
	{
		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x170008EF")]
		public int BossTypeId
		{
			[Token(Token = "0x6002E51")]
			[Address(RVA = "0x7ECC", Offset = "0x7ECC", VA = "0x7ECC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x6002E52")]
		[Address(RVA = "0x7ECD", Offset = "0x7ECD", VA = "0x7ECD", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E53")]
		[Address(RVA = "0x7ECE", Offset = "0x7ECE", VA = "0x7ECE")]
		public BossInstanceTypeTag_34()
		{
		}

		// Token: 0x04001969 RID: 6505
		[Token(Token = "0x4001969")]
		public const string BOSS_TITLE = "boss_title";

		// Token: 0x0400196A RID: 6506
		[Token(Token = "0x400196A")]
		public const string BOSS_VIEW = "boss_view";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BossTypeId ---
		int Gameplay_GameEvents_Model_Tags_BossInstanceTypeTag_34__get_BossTypeId
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,int param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  int *piVar5;
		  int *piVar6;
		  int iVar7;
		  double dVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a574cf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_AprTagView___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3190);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20738);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20736);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574cf = '\x01';
		  }
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
		    return 0;
		  }
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		  *param4 = uVar1;
		  iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_20736,0);
		  if (iVar3 == 0) {
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_20738,0);
		    if (iVar3 != 0) {
		      uVar9 = 0;
		      *param4 = StringLiteral_5;
		      piVar6 = (int *)Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                                (param1,StringLiteral_3190,*(undefined4 *)(param5 + 8),
		                                 Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_AprTagView___
		                                );
		      piVar5 = (int *)param1[2];
		      iVar3 = *piVar5;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d93938;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d93938:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      iVar7 = param1[5];
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      dVar8 = *(double *)(iVar7 + iVar3 * 8 + 8);
		      if (ABS(dVar8) < 2147483648.0) {
		        iVar3 = (int)dVar8;
		      }
		      else {
		        iVar3 = -0x80000000;
		      }
		      uVar9 = 0;
		      iVar3 = Core_Extensions_Dict_DictExt__GetStoneDic(uVar1,iVar3,0);
		      piVar5 = (int *)param1[2];
		      iVar7 = *piVar5;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0xd0);
		            goto code_r0x80d93a0b;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d93a0b:
		      uVar9 = 0;
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      iVar3 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic
		                        (uVar1,*(undefined4 *)(iVar3 + 0x10),0);
		      piVar5 = (int *)param1[2];
		      iVar7 = *piVar5;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0xd8);
		            goto code_r0x80d93a9b;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x80d93a9b:
		      iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      uVar1 = func_ii_7730(*(undefined4 *)(iVar7 + 0x14),*(undefined4 *)(iVar3 + 0x10),
		                           Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                          );
		      (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x138) * 4))
		                (piVar6,uVar1,*(undefined4 *)(*piVar6 + 0x13c));
		      piVar6[0x16] = 2;
		    }
		    return iVar2;
		  }
		  piVar6 = (int *)param1[2];
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80d937f6;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d937f6:
		  uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar7 = param1[5];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  dVar8 = *(double *)(iVar7 + iVar3 * 8 + 8);
		  if (ABS(dVar8) < 2147483648.0) {
		    iVar3 = (int)dVar8;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  uVar9 = 0;
		  iVar3 = Core_Extensions_Dict_DictExt__GetStoneDic(uVar1,iVar3,0);
		  piVar6 = (int *)param1[2];
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x80d938c9;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d938c9:
		  uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic
		                    (uVar1,*(undefined4 *)(iVar3 + 0x10),0);
		  uVar1 = AssetContent_GameAssetViewRawImage__set_AssetId(uVar1,0);
		  *param4 = uVar1;
		  return iVar2;
		}
		*/

}
