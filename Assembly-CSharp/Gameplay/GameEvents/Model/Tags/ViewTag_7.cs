using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B8 RID: 1976
	[Token(Token = "0x20007B8")]
	public class ViewTag_7 : AbstractTag
	{
		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x17000914")]
		public uint MedalId
		{
			[Token(Token = "0x6002EB0")]
			[Address(RVA = "0x7F2B", Offset = "0x7F2B", VA = "0x7F2B")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0x7F2C", Offset = "0x7F2C", VA = "0x7F2C", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB2")]
		[Address(RVA = "0x7F2D", Offset = "0x7F2D", VA = "0x7F2D")]
		public ViewTag_7()
		{
		}

		// Token: 0x04001995 RID: 6549
		[Token(Token = "0x4001995")]
		public const string VIEW_TITLE = "view_title";

		// Token: 0x04001996 RID: 6550
		[Token(Token = "0x4001996")]
		public const string VIEW_REWARD = "view_reward";

		// Token: 0x04001997 RID: 6551
		[Token(Token = "0x4001997")]
		public const string VIEW_VIEW = "view_view";

		// Token: 0x04001998 RID: 6552
		[Token(Token = "0x4001998")]
		public const string APR_PREFAB_PATH = "AprTagView";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MedalId ---
		int Gameplay_GameEvents_Model_Tags_ViewTag_7__get_MedalId
		              (int *param1,undefined4 param2,int param3,undefined4 *param4,int param5,
		              undefined4 param6)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param3_00;
		  undefined8 uVar6;
		  int *piVar7;
		  int *param1_00;
		  double dVar8;
		  uint uVar9;
		  int iVar10;
		  
		  if (DAT_ram_00a574ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_AprTagView___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__UserData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3190);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28289);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28290);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28291);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574ea = '\x01';
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
		  uVar6 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xf4));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,uVar6);
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 == 0) {
		    *param4 = 0;
		    return 0;
		  }
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		  *param4 = uVar1;
		  iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_28290,0);
		  if (iVar3 == 0) {
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_28291,0);
		    if (iVar3 == 0) {
		      iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_28289,0);
		      if (iVar3 != 0) {
		        *param4 = StringLiteral_5;
		        return iVar2;
		      }
		    }
		    else {
		      *param4 = StringLiteral_5;
		      if (param5 != 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar9 = 0;
		        piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar3 = *piVar7;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0x140
		                               );
		              goto code_r0x80d98a37;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80d98a37:
		        uVar6 = CONCAT44(uVar5,puVar4[1]);
		        uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,uVar6);
		        uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		        uVar1 = func_ii_7112(uVar1,0);
		        if (0 < *(int *)(*(int *)(param3 + 0x28) + 0xc)) {
		          uVar6 = func_ii_7271(*(undefined4 *)(*(int *)(param3 + 0x24) + 0x30),0,
		                               Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		          uVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                            (*(undefined4 *)(*(int *)(param3 + 0x18) + 0x14),uVar6,
		                             Method_System_Collections_Generic_Dictionary_ulong__UserData__get_Item__
		                            );
		          uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		        }
		        piVar7 = (int *)Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                                  (param1,StringLiteral_3190,*(undefined4 *)(param5 + 8),
		                                   Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_AprTagView___
		                                  );
		        dVar8 = *(double *)(param1[5] + 0x10);
		        if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		          iVar3 = (int)dVar8;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar8) < 2147483648.0) {
		          iVar10 = (int)dVar8;
		        }
		        else {
		          iVar10 = -0x80000000;
		        }
		        if (0.0 <= dVar8) {
		          iVar10 = iVar3;
		        }
		        piVar7[0x17] = iVar10;
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar9 = 0;
		        param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar3 = *param1_00;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0x178
		                               );
		              goto code_r0x80d98bac;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		        }
		        puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d98bac:
		        uVar6 = CONCAT44(uVar5,puVar4[1]);
		        param3_00 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar6);
		        uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		        uVar1 = Gameplay_Aprs_Model_AprData__InvalidateUser(iVar10,uVar1,param3_00,0);
		        (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x138) * 4))
		                  (piVar7,CONCAT44(uVar5,uVar1),*(undefined4 *)(*piVar7 + 0x13c));
		      }
		    }
		    return iVar2;
		  }
		  piVar7 = (int *)param1[2];
		  iVar3 = *piVar7;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80d98901;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d98901:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,CONCAT44(uVar5,puVar4[1]));
		  dVar8 = *(double *)(param1[5] + 0x10);
		  if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		    iVar3 = (int)dVar8;
		  }
		  else {
		    iVar3 = 0;
		  }
		  if (ABS(dVar8) < 2147483648.0) {
		    iVar10 = (int)dVar8;
		  }
		  else {
		    iVar10 = -0x80000000;
		  }
		  if (0.0 <= dVar8) {
		    iVar10 = iVar3;
		  }
		  uVar5 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                    (uVar5,iVar10,0);
		  uVar5 = func_ii_14054(uVar5,0);
		  *param4 = uVar5;
		  return iVar2;
		}
		*/

}
