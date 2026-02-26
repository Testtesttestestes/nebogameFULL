using System;
using Il2CppDummyDll;

namespace UI.Rewards.Renderers
{
	// Token: 0x020001A9 RID: 425
	[Token(Token = "0x20001A9")]
	public class ArtikulGroupRewardRender : AbstractRewardRender
	{
		// Token: 0x06000B91 RID: 2961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x5EAA", Offset = "0x5EAA", VA = "0x5EAA", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x5EAB", Offset = "0x5EAB", VA = "0x5EAB")]
		public ArtikulGroupRewardRender()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_ArtikulGroupRewardRender___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  uint uVar6;
		  int iVar7;
		  longlong local_8;
		  
		  if (DAT_ram_00a59a2e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IconValueRender___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59a2e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  piVar2 = (int *)func_ii_7225(uVar1,0);
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x810ae7b3;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810ae7b3:
		  piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  uVar6 = 0;
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_long__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810ae835;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810ae835:
		  local_8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,0,puVar3[1]);
		  if (0 < local_8) {
		    piVar2 = (int *)param1[5];
		    iVar5 = param1[4];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xf4));
		    iVar7 = *piVar2;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0xe8) * 4))
		                      (piVar2,iVar5,uVar1,*(undefined4 *)(iVar7 + 0xec));
		    piVar2 = (int *)func_ii_5677(uVar1,Method_UnityEngine_Component_GetComponent_IconValueRender___)
		    ;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xf4));
		    iVar5 = func_ii_8038(uVar1,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 2;
		    if (iVar5 != 0x19) {
		      uVar1 = 1;
		    }
		    uVar6 = 0;
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x178);
		          goto code_r0x810ae957;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810ae957:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    iVar5 = Core_Extensions_Dict_DictExt__GetArtikulTypeMenuActionDic(uVar4,uVar1,0);
		    if (iVar5 != 0) {
		      uVar1 = Core_Extensions_Dict_EventTypeDicExt__GetDescription(iVar5,0);
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(piVar2[10],uVar1,0);
		    }
		    iVar5 = UnityEngine_GameObject__SetActive(&local_8,0);
		    if (iVar5 == 0) {
		      iVar5 = StringLiteral_5;
		    }
		    iVar7 = System_Collections_CollectionBase___ctor(piVar2[0xc],iVar5,0);
		    if (iVar7 == 0) {
		      piVar2[0xc] = iVar5;
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x110) * 4))
		                (piVar2,*(undefined4 *)(*piVar2 + 0x114));
		    }
		  }
		  return;
		}
		*/

		}
	}
}
