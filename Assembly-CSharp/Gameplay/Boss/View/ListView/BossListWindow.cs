using System;
using AssetContent;
using Gameplay.Boss.Controller;
using Il2CppDummyDll;
using TMPro;
using UI.Requirements;
using UI.Tabs;
using UI.Toggle;
using UI.Wiki;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.ListView
{
	// Token: 0x02000B6B RID: 2923
	[Token(Token = "0x2000B6B")]
	public class BossListWindow : ClosableBaseWindow<BossListWindowArgs>
	{
		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E16")]
		public override string WindowId
		{
			[Token(Token = "0x60046F5")]
			[Address(RVA = "0x958B", Offset = "0x958B", VA = "0x958B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E17")]
		public RequirementsView RequirementsView
		{
			[Token(Token = "0x60046F6")]
			[Address(RVA = "0x958C", Offset = "0x958C", VA = "0x958C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x060046F7 RID: 18167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E18")]
		public GameObject FilteredEmptyListView
		{
			[Token(Token = "0x60046F7")]
			[Address(RVA = "0x958D", Offset = "0x958D", VA = "0x958D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E19")]
		public BossPossibleEmptyWindowStateController StateController
		{
			[Token(Token = "0x60046F8")]
			[Address(RVA = "0x958E", Offset = "0x958E", VA = "0x958E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E1A")]
		public TextMeshProUGUI DescriptionLabel
		{
			[Token(Token = "0x60046F9")]
			[Address(RVA = "0x958F", Offset = "0x958F", VA = "0x958F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x060046FA RID: 18170 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E1B")]
		public TextMeshProUGUI CountLabel
		{
			[Token(Token = "0x60046FA")]
			[Address(RVA = "0x9590", Offset = "0x9590", VA = "0x9590")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E1C")]
		public GreenToggle GreenToggle
		{
			[Token(Token = "0x60046FB")]
			[Address(RVA = "0x9591", Offset = "0x9591", VA = "0x9591")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E1D")]
		public Button ActionButton
		{
			[Token(Token = "0x60046FC")]
			[Address(RVA = "0x9592", Offset = "0x9592", VA = "0x9592")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E1E")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x60046FD")]
			[Address(RVA = "0x9593", Offset = "0x9593", VA = "0x9593")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (set) Token: 0x060046FE RID: 18174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E1F")]
		public string ActionButtonTitle
		{
			[Token(Token = "0x60046FE")]
			[Address(RVA = "0x9594", Offset = "0x9594", VA = "0x9594")]
			set
			{
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E20")]
		public BossListAdapter BossListAdapter
		{
			[Token(Token = "0x60046FF")]
			[Address(RVA = "0x9595", Offset = "0x9595", VA = "0x9595")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06004700 RID: 18176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E21")]
		public TabBar TabBar
		{
			[Token(Token = "0x6004700")]
			[Address(RVA = "0x9596", Offset = "0x9596", VA = "0x9596")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E22")]
		public GameAssetViewRawImage Avatar
		{
			[Token(Token = "0x6004701")]
			[Address(RVA = "0x9597", Offset = "0x9597", VA = "0x9597")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004702")]
		[Address(RVA = "0x9598", Offset = "0x9598", VA = "0x9598", Slot = "22")]
		protected override void OnShow(BossListWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Boss_View_ListView_BossListWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a57a10 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BossListWindowArgs__OnClose__);
		    DAT_ram_00a57a10 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_BossListWindowArgs__OnClose__);
		  piVar1 = *(int **)(param1 + 0x6c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x6c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004703 RID: 18179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004703")]
		[Address(RVA = "0x9599", Offset = "0x9599", VA = "0x9599", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Boss_View_ListView_BossListWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a11 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_BossListWindowArgs___ctor__);
		    DAT_ram_00a57a11 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_BossListWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004704 RID: 18180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004704")]
		[Address(RVA = "0x959A", Offset = "0x959A", VA = "0x959A")]
		public BossListWindow()
		{
		}

		// Token: 0x040026E5 RID: 9957
		[Token(Token = "0x40026E5")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Boss/BossListWindow";

		// Token: 0x040026E6 RID: 9958
		[Token(Token = "0x40026E6")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BossPossibleEmptyWindowStateController _stateController;

		// Token: 0x040026E7 RID: 9959
		[Token(Token = "0x40026E7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040026E8 RID: 9960
		[Token(Token = "0x40026E8")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BossListAdapter _bossListAdapter;

		// Token: 0x040026E9 RID: 9961
		[Token(Token = "0x40026E9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x040026EA RID: 9962
		[Token(Token = "0x40026EA")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _actionButton;

		// Token: 0x040026EB RID: 9963
		[Token(Token = "0x40026EB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _actionButtonLabel;

		// Token: 0x040026EC RID: 9964
		[Token(Token = "0x40026EC")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _countLabel;

		// Token: 0x040026ED RID: 9965
		[Token(Token = "0x40026ED")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _descriptionLabel;

		// Token: 0x040026EE RID: 9966
		[Token(Token = "0x40026EE")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _filteredEmptyListView;

		// Token: 0x040026EF RID: 9967
		[Token(Token = "0x40026EF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GreenToggle _greenToggle;

		// Token: 0x040026F0 RID: 9968
		[Token(Token = "0x40026F0")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x040026F1 RID: 9969
		[Token(Token = "0x40026F1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x040026F2 RID: 9970
		[Token(Token = "0x40026F2")]
		[FieldOffset(Offset = "0x6C")]
		private BossListWindowMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Wiki ---
		void Gameplay_Boss_View_ListView_BossListWindow__get_Wiki
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x50),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: get_Avatar ---
		void Gameplay_Boss_View_ListView_BossListWindow__get_Avatar
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a57a0f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_BossListWindowArgs__get_WindowArgs__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossListWindowMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_BossListWindowArgs__OnShow__)
		    ;
		    DAT_ram_00a57a0f = '\x01';
		  }
		  func_ii_7769(param1,param2,Method_UI_Windows_ClosableBaseWindow_BossListWindowArgs__OnShow__);
		  iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_BossListWindowArgs__get_WindowArgs__);
		  param2_00 = *(undefined4 *)(iVar1 + 0x20);
		  iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_BossListWindowArgs__get_WindowArgs__);
		  param3_00 = *(undefined4 *)(iVar1 + 0x1c);
		  iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_BossListWindowArgs__get_WindowArgs__);
		  param4 = *(undefined4 *)(iVar1 + 0x18);
		  param1_00 = (int *)unnamed_function_1417(Gameplay_Boss_Controller_BossListWindowMediator_TypeInfo)
		  ;
		  Gameplay_Boss_Controller_BossListWindowMediator__Dispose(param1_00,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x6c) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
