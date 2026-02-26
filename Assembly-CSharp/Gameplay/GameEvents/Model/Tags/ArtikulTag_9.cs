using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x02000798 RID: 1944
	[Token(Token = "0x2000798")]
	public class ArtikulTag_9 : AbstractTag
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x170008ED")]
		public uint ArtikulId
		{
			[Token(Token = "0x6002E4B")]
			[Address(RVA = "0x7EC6", Offset = "0x7EC6", VA = "0x7EC6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x6002E4C")]
		[Address(RVA = "0x7EC7", Offset = "0x7EC7", VA = "0x7EC7", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x7EC8", Offset = "0x7EC8", VA = "0x7EC8")]
		public ArtikulTag_9()
		{
		}

		// Token: 0x04001966 RID: 6502
		[Token(Token = "0x4001966")]
		public const string ARTIKUL_TITLE = "artikul_title";

		// Token: 0x04001967 RID: 6503
		[Token(Token = "0x4001967")]
		public const string ARTIKUL_VIEW = "artikul_view";

		// Token: 0x04001968 RID: 6504
		[Token(Token = "0x4001968")]
		public const string VIEW_PREFAB = "ArtikulTagView";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ArtikulId ---
		int Gameplay_GameEvents_Model_Tags_ArtikulTag_9__get_ArtikulId
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,int param5,
		              undefined4 param6)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *piVar5;
		  int param1_01;
		  int *param1_02;
		  double dVar6;
		  uint uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a574cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_ArtikulTagView___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19946);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19945);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3307);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574cd = '\x01';
		  }
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  uVar2 = 0;
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar1 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (param1_00,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar1 != 0) {
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar2;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_19945,0);
		    if (iVar3 == 0) {
		      iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_19946,0);
		      if (iVar3 == 0) {
		        return iVar1;
		      }
		      iVar3 = Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                        (param1,StringLiteral_3307,*(undefined4 *)(param5 + 8),
		                         Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_ArtikulTagView___
		                        );
		      dVar6 = *(double *)(param1[5] + 0x10);
		      if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		        iVar8 = (int)dVar6;
		      }
		      else {
		        iVar8 = 0;
		      }
		      if (ABS(dVar6) < 2147483648.0) {
		        param1_01 = (int)dVar6;
		      }
		      else {
		        param1_01 = -0x80000000;
		      }
		      piVar5 = *(int **)(iVar3 + 0x10);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      if (0.0 <= dVar6) {
		        param1_01 = iVar8;
		      }
		      uVar7 = 0;
		      param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar3 = *param1_02;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 0x178);
		            goto code_r0x80d933b6;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d933b6:
		      uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_02,puVar4[1]);
		      uVar2 = func_ii_7944(param1_01,uVar2,0);
		      iVar3 = *piVar5;
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		                (piVar5,uVar2,*(undefined4 *)(iVar3 + 0x13c));
		      uVar2 = StringLiteral_5;
		    }
		    else {
		      piVar5 = (int *)param1[2];
		      iVar3 = *piVar5;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d93253;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d93253:
		      uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
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
		      uVar2 = Gameplay_Inventory_Model_InventoryBaseModel__GetCount(uVar2,iVar8,0);
		      uVar2 = Core_Extensions_Dict_DictExt__GetArtikul(uVar2,0);
		    }
		  }
		  *param4 = uVar2;
		  return iVar1;
		}
		*/

}
