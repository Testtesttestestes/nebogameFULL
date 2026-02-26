using System;
using System.Runtime.CompilerServices;
using Core.Dict;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish;
using Gameplay.Ad.BattleFinishAd.Controller;
using Gameplay.Combat.Model;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gameplay.Ad.BattleFinishAd.View
{
	// Token: 0x02000DB4 RID: 3508
	[Token(Token = "0x2000DB4")]
	public class BattleFinishAdView : MonoBehaviour
	{
		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x060055AE RID: 21934 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700116A")]
		public ArtikulView ArtikulView
		{
			[Token(Token = "0x60055AE")]
			[Address(RVA = "0xA34E", Offset = "0xA34E", VA = "0xA34E")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x060055AF RID: 21935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700116B")]
		public Button WatchButton
		{
			[Token(Token = "0x60055AF")]
			[Address(RVA = "0xA34F", Offset = "0xA34F", VA = "0xA34F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x060055B0 RID: 21936 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700116C")]
		public BattleFinishAdViewState State
		{
			[Token(Token = "0x60055B0")]
			[Address(RVA = "0xA350", Offset = "0xA350", VA = "0xA350")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060055B1 RID: 21937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700116D")]
		public BattleFinishAdView.BattleFinishAdViewArgs Args
		{
			[Token(Token = "0x60055B2")]
			[Address(RVA = "0xA352", Offset = "0xA352", VA = "0xA352")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60055B1")]
			[Address(RVA = "0xA351", Offset = "0xA351", VA = "0xA351")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B3")]
		[Address(RVA = "0xA353", Offset = "0xA353", VA = "0xA353")]
		public void Init(BattleFinishAdView.BattleFinishAdViewArgs args)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Ad_BattleFinishAd_View_BattleFinishAdView__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x1c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B4")]
		[Address(RVA = "0xA354", Offset = "0xA354", VA = "0xA354")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Ad_BattleFinishAd_View_BattleFinishAdView__OnDestroy
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58855 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58855 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B5")]
		[Address(RVA = "0xA355", Offset = "0xA355", VA = "0xA355")]
		public void Hide()
		{
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B6")]
		[Address(RVA = "0xA356", Offset = "0xA356", VA = "0xA356")]
		public BattleFinishAdView()
		{
		}

		// Token: 0x04002E69 RID: 11881
		[Token(Token = "0x4002E69")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04002E6A RID: 11882
		[Token(Token = "0x4002E6A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x04002E6B RID: 11883
		[Token(Token = "0x4002E6B")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("_stateController")]
		[SerializeField]
		private BattleFinishAdViewState _state;

		// Token: 0x04002E6C RID: 11884
		[Token(Token = "0x4002E6C")]
		[FieldOffset(Offset = "0x1C")]
		private BattleFinishAdViewMediator _mediator;

		// Token: 0x02000DB5 RID: 3509
		[Token(Token = "0x2000DB5")]
		public class BattleFinishAdViewArgs
		{
			// Token: 0x060055B7 RID: 21943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60055B7")]
			[Address(RVA = "0xA357", Offset = "0xA357", VA = "0xA357")]
			public BattleFinishAdViewArgs(BattleFinishAdPlacementManager manager, GameOverData gameOverData, IDictProvider dictProvider)
			{
			}

			// Token: 0x04002E6E RID: 11886
			[Token(Token = "0x4002E6E")]
			[FieldOffset(Offset = "0x8")]
			public readonly BattleFinishAdPlacementManager Manager;

			// Token: 0x04002E6F RID: 11887
			[Token(Token = "0x4002E6F")]
			[FieldOffset(Offset = "0xC")]
			public readonly GameOverData GameOverData;

			// Token: 0x04002E70 RID: 11888
			[Token(Token = "0x4002E70")]
			[FieldOffset(Offset = "0x10")]
			public readonly IDictProvider DictProvider;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Args ---
		void Gameplay_Ad_BattleFinishAd_View_BattleFinishAdView__get_Args
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param5;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58854 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_TypeInfo);
		    DAT_ram_00a58854 = '\x01';
		  }
		  *(int *)(param1 + 0x20) = param2;
		  iVar1 = *(int *)(param2 + 8);
		  param5 = *(undefined4 *)(iVar1 + 0x18);
		  param4 = *(undefined4 *)(iVar1 + 0x20);
		  param3_00 = *(undefined4 *)(iVar1 + 0x1c);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_TypeInfo);
		  if (DAT_ram_00a58857 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents__BattleFinishAdPlacementController__BattleFinishAdView___ctor__
		              );
		    DAT_ram_00a58857 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1_00,param1,param3_00,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents__BattleFinishAdPlacementController__BattleFinishAdView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  return;
		}
		*/

}
