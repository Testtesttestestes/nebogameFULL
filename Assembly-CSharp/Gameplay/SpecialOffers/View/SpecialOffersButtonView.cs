using System;
using AssetContent;
using Gameplay.SpecialOffers.Controller;
using Il2CppDummyDll;
using UI;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SpecialOffers.View
{
	// Token: 0x020004FC RID: 1276
	[Token(Token = "0x20004FC")]
	public class SpecialOffersButtonView : MonoBehaviour
	{
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000589")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6001E71")]
			[Address(RVA = "0x6FEA", Offset = "0x6FEA", VA = "0x6FEA")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700058A")]
		public Button Button
		{
			[Token(Token = "0x6001E72")]
			[Address(RVA = "0x6FEB", Offset = "0x6FEB", VA = "0x6FEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700058B")]
		public GameAssetViewRawImage GameAssetView
		{
			[Token(Token = "0x6001E73")]
			[Address(RVA = "0x6FEC", Offset = "0x6FEC", VA = "0x6FEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700058C")]
		public CounterAutoHide RedCounter
		{
			[Token(Token = "0x6001E74")]
			[Address(RVA = "0x6FED", Offset = "0x6FED", VA = "0x6FED")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700058D")]
		public GameObject AdMarker
		{
			[Token(Token = "0x6001E75")]
			[Address(RVA = "0x6FEE", Offset = "0x6FEE", VA = "0x6FEE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E76")]
		[Address(RVA = "0x6FEF", Offset = "0x6FEF", VA = "0x6FEF")]
		private void Start()
		{
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E77")]
		[Address(RVA = "0x6FF0", Offset = "0x6FF0", VA = "0x6FF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x6FF1", Offset = "0x6FF1", VA = "0x6FF1")]
		public SpecialOffersButtonView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_SpecialOffers_View_SpecialOffersButtonView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58619 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12671);
		    DAT_ram_00a58619 = '\x01';
		  }
		  return StringLiteral_12671;
		}
		*/

		}

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _gameAssetView;

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _buttonArea;

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterAutoHide _redCounter;

		// Token: 0x04001094 RID: 4244
		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _adMarker;

		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0x24")]
		private SpecialOffersEnterPointViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AdMarker ---
		void Gameplay_SpecialOffers_View_SpecialOffersButtonView__get_AdMarker(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *piVar3;
		  int iVar4;
		  int *param4;
		  
		  if (DAT_ram_00a58618 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_TypeInfo);
		    DAT_ram_00a58618 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x200);
		        goto code_r0x80f15782;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x28);
		code_r0x80f15782:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(int **)(iVar4 + 0x10);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                        (param4,*(undefined4 *)(*param4 + 0x104));
		  param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                     (param4,*(undefined4 *)(*param4 + 0x114));
		  piVar3 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_SpecialOffers_Controller_SpecialOffersEnterPointViewMediator_TypeInfo
		                            );
		  if (DAT_ram_00a58648 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView___ctor__
		              );
		    DAT_ram_00a58648 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3,param4,
		             Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersButtonView___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  *(int **)(param1 + 0x24) = piVar3;
		  return;
		}
		*/

}
