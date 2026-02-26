using System;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Ad.BattleBonusesAd.View
{
	// Token: 0x02000DBE RID: 3518
	[Token(Token = "0x2000DBE")]
	public class BattleBonusesBonusRenderer : AbstractDataRenderer<MedalData>
	{
		// Token: 0x060055D3 RID: 21971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D3")]
		[Address(RVA = "0xA373", Offset = "0xA373", VA = "0xA373", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesBonusRenderer__HandleDataChanged
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  int iVar1;
		  undefined4 uVar2;
		  float fVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined8 uVar7;
		  
		  if (DAT_ram_00a5886b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2520);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2518);
		    DAT_ram_00a5886b = '\x01';
		  }
		  uVar7 = CONCAT44(in_register_20000004,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (uVar7,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),param1);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (uVar7,*(undefined4 *)(*param1 + 0x134));
		    uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    iVar1 = func_ii_8766(uVar2,0);
		    if (*(longlong *)(*(int *)(iVar1 + 0x10) + 0x40) == 0) {
		      uVar7 = CONCAT44(uVar4,param1);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (uVar7,*(undefined4 *)(*param1 + 0x134));
		      uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      if (*(int *)(iVar1 + 0x1c) == 0) goto code_r0x80f367a3;
		    }
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xb],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    uVar7 = CONCAT44(uVar4,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (uVar7,*(undefined4 *)(*param1 + 0x134));
		    piVar5 = (int *)param1[10];
		    uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    if (*(int *)(iVar1 + 0x1c) != 0) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2518,1,0,1,0,0,0,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x2d0) * 4))
		                (CONCAT44(uVar4,piVar5),uVar2,*(undefined4 *)(*piVar5 + 0x2d4));
		      iVar6 = param1[0xb];
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      UI_Elements_RightPanel_TitleWithLevel__set_Level(iVar6,*(undefined4 *)(iVar1 + 0x1c),0);
		      return;
		    }
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2520,1,0,1,0,0,0,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x2d0) * 4))
		              (CONCAT44(uVar4,piVar5),uVar2,*(undefined4 *)(*piVar5 + 0x2d4));
		    iVar6 = param1[0xb];
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar1 = func_ii_8766(uVar4,0);
		    uVar7 = *(undefined8 *)(*(int *)(iVar1 + 0x10) + 0x40);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar3 = Utils_StringUtils___cctor(uVar7,0);
		    uVar4 = Utils_TimeUtils__DateFormat((double)fVar3,0);
		    UI_AbstractBacktimeView__set_FormatBackTimeCallback(iVar6,uVar4,0);
		    return;
		  }
		code_r0x80f367a3:
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0xb],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D4")]
		[Address(RVA = "0xA374", Offset = "0xA374", VA = "0xA374")]
		private void RenderDuration()
		{
		/* --- GHIDRA: RenderDuration ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesBonusRenderer__RenderDuration
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5886c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_MedalData___ctor__);
		    DAT_ram_00a5886c = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_MedalData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D5")]
		[Address(RVA = "0xA375", Offset = "0xA375", VA = "0xA375")]
		public BattleBonusesBonusRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesBonusRenderer___ctor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5886d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView__Dispose__
		              );
		    DAT_ram_00a5886d = '\x01';
		  }
		  if (param1[6] != 0) {
		    func_ii_7950(param1[6],0);
		  }
		  param1[6] = 0;
		  if (param1[7] != 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_20511(param1_00,param1[7],0);
		  }
		  param1[7] = 0;
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002E83 RID: 11907
		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04002E84 RID: 11908
		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _backtimePrefix;

		// Token: 0x04002E85 RID: 11909
		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private AbstractBacktimeView _backtimeView;
	}
}
