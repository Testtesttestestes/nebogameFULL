using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A9 RID: 1961
	[Token(Token = "0x20007A9")]
	public class Isle_29 : AbstractTag
	{
		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x17000902")]
		public uint MedalId
		{
			[Token(Token = "0x6002E80")]
			[Address(RVA = "0x7EFB", Offset = "0x7EFB", VA = "0x7EFB")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x6002E81")]
		[Address(RVA = "0x7EFC", Offset = "0x7EFC", VA = "0x7EFC", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E82")]
		[Address(RVA = "0x7EFD", Offset = "0x7EFD", VA = "0x7EFD")]
		public Isle_29()
		{
		}

		// Token: 0x0400197B RID: 6523
		[Token(Token = "0x400197B")]
		public const string ISLE_VIEW = "isle_view";

		// Token: 0x0400197C RID: 6524
		[Token(Token = "0x400197C")]
		public const string ISLE_WIDGET_PREFAB = "IsleTagView";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MedalId ---
		uint Gameplay_GameEvents_Model_Tags_Isle_29__get_MedalId
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,int param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  double dVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a574dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_LoaderTagView___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_uint___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9971);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24827);
		    DAT_ram_00a574dc = '\x01';
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
		  uVar8 = 1;
		  iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_24827,0);
		  if ((iVar2 != 0) && (*param4 = StringLiteral_5, param5 != 0)) {
		    uVar8 = 0;
		    iVar2 = Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                      (param1,StringLiteral_9971,*(undefined4 *)(param5 + 8),
		                       Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_LoaderTagView___);
		    piVar4 = (int *)param1[2];
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80d95d51;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d95d51:
		    uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    iVar6 = param1[5];
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    dVar7 = *(double *)(iVar6 + iVar5 * 8 + 8);
		    if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		      iVar5 = (int)dVar7;
		    }
		    else {
		      iVar5 = 0;
		    }
		    if (ABS(dVar7) < 2147483648.0) {
		      iVar6 = (int)dVar7;
		    }
		    else {
		      iVar6 = -0x80000000;
		    }
		    if (0.0 <= dVar7) {
		      iVar6 = iVar5;
		    }
		    iVar5 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                      (uVar1,iVar6,0);
		    uVar1 = *(undefined4 *)(iVar5 + 0x28);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    iVar5 = Core_Extensions_Dict_RewardInfoExt__ToRewardDataArray(uVar1,0xf,0);
		    uVar1 = System_Linq_Enumerable__First_long_
		                      (*(undefined4 *)(iVar5 + 0x10),Method_System_Linq_Enumerable_First_uint___);
		    piVar4 = (int *)param1[2];
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80d95e90;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d95e90:
		    param2_00 = 0;
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    iVar5 = Core_Extensions_Dict_DictExt__GetClanCult(param1_00,uVar1,0);
		    if (iVar5 != 0) {
		      param2_00 = Core_Extensions_Dict_IsleDecorationsDicExt__GetAnimationAssetId(iVar5,0);
		    }
		    if (DAT_ram_00a574a2 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameRawImage___);
		      DAT_ram_00a574a2 = '\x01';
		    }
		    uVar8 = (uint)(param5 != 0);
		    iVar5 = *(int *)(iVar2 + 0x10);
		    if (iVar5 == 0) {
		      iVar5 = func_ii_5677(iVar2,Method_UnityEngine_Component_GetComponent_GameRawImage___);
		    }
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(iVar5,param2_00,0);
		  }
		  return uVar8;
		}
		*/

}
