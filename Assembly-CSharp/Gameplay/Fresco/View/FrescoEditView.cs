using System;
using Gameplay.Bank.View;
using Gameplay.Inventory.View;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Requirements;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007EB RID: 2027
	[Token(Token = "0x20007EB")]
	public class FrescoEditView : MonoBehaviourWithStates<FrescoEditView.States>
	{
		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700093B")]
		public FrescoFieldEditable FrescoField
		{
			[Token(Token = "0x6002F95")]
			[Address(RVA = "0x7FFB", Offset = "0x7FFB", VA = "0x7FFB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700093C")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002F96")]
			[Address(RVA = "0x7FFC", Offset = "0x7FFC", VA = "0x7FFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700093D")]
		public TextMeshProUGUI TitleCounter
		{
			[Token(Token = "0x6002F97")]
			[Address(RVA = "0x7FFD", Offset = "0x7FFD", VA = "0x7FFD")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700093E")]
		public ArtikulView KeyArtikulView
		{
			[Token(Token = "0x6002F98")]
			[Address(RVA = "0x7FFE", Offset = "0x7FFE", VA = "0x7FFE")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700093F")]
		public FrescoFragment KeyFrescoFragment
		{
			[Token(Token = "0x6002F99")]
			[Address(RVA = "0x7FFF", Offset = "0x7FFF", VA = "0x7FFF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000940")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x6002F9A")]
			[Address(RVA = "0x8000", Offset = "0x8000", VA = "0x8000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000941")]
		public GameObject Requirements
		{
			[Token(Token = "0x6002F9B")]
			[Address(RVA = "0x8001", Offset = "0x8001", VA = "0x8001")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000942")]
		public RequirementsView RequirementsView
		{
			[Token(Token = "0x6002F9C")]
			[Address(RVA = "0x8002", Offset = "0x8002", VA = "0x8002")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000943")]
		public LoaderValueRowView AdditionalRequirements
		{
			[Token(Token = "0x6002F9D")]
			[Address(RVA = "0x8003", Offset = "0x8003", VA = "0x8003")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000944")]
		public Button AdditionalRequirementsButton
		{
			[Token(Token = "0x6002F9E")]
			[Address(RVA = "0x8004", Offset = "0x8004", VA = "0x8004")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000945")]
		public TextMeshProUGUI SelectedUniversalFragmentCounter
		{
			[Token(Token = "0x6002F9F")]
			[Address(RVA = "0x8005", Offset = "0x8005", VA = "0x8005")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000946")]
		public TextMeshProUGUI UniversalFragmentCounter
		{
			[Token(Token = "0x6002FA0")]
			[Address(RVA = "0x8006", Offset = "0x8006", VA = "0x8006")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000947")]
		public TextMeshProUGUI InstallAndContinueInfo
		{
			[Token(Token = "0x6002FA1")]
			[Address(RVA = "0x8007", Offset = "0x8007", VA = "0x8007")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000948")]
		public BankOptionsListView BankOptionsListView
		{
			[Token(Token = "0x6002FA2")]
			[Address(RVA = "0x8008", Offset = "0x8008", VA = "0x8008")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000949")]
		public Button BuyUniversalFragmentButton
		{
			[Token(Token = "0x6002FA3")]
			[Address(RVA = "0x8009", Offset = "0x8009", VA = "0x8009")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700094A")]
		public Button InstallAllUniversalButton
		{
			[Token(Token = "0x6002FA4")]
			[Address(RVA = "0x800A", Offset = "0x800A", VA = "0x800A")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700094B")]
		public Button CloseTopButton
		{
			[Token(Token = "0x6002FA5")]
			[Address(RVA = "0x800B", Offset = "0x800B", VA = "0x800B")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700094C")]
		public Button LeftButton
		{
			[Token(Token = "0x6002FA6")]
			[Address(RVA = "0x800C", Offset = "0x800C", VA = "0x800C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700094D")]
		public Button RightButton
		{
			[Token(Token = "0x6002FA7")]
			[Address(RVA = "0x800D", Offset = "0x800D", VA = "0x800D")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700094E")]
		public Button InstallAllButton
		{
			[Token(Token = "0x6002FA8")]
			[Address(RVA = "0x800E", Offset = "0x800E", VA = "0x800E")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700094F")]
		public Button CompleteFrescoButton
		{
			[Token(Token = "0x6002FA9")]
			[Address(RVA = "0x800F", Offset = "0x800F", VA = "0x800F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000950")]
		public Button InstallAndContinueButton
		{
			[Token(Token = "0x6002FAA")]
			[Address(RVA = "0x8010", Offset = "0x8010", VA = "0x8010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000951")]
		public Button AcceptButton
		{
			[Token(Token = "0x6002FAB")]
			[Address(RVA = "0x8011", Offset = "0x8011", VA = "0x8011")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002FAC RID: 12204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000952")]
		public Button CollectRewardButton
		{
			[Token(Token = "0x6002FAC")]
			[Address(RVA = "0x8012", Offset = "0x8012", VA = "0x8012")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000953")]
		public Button InstallUniversalButton
		{
			[Token(Token = "0x6002FAD")]
			[Address(RVA = "0x8013", Offset = "0x8013", VA = "0x8013")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000954")]
		public GameObject KeyObjectView
		{
			[Token(Token = "0x6002FAE")]
			[Address(RVA = "0x8014", Offset = "0x8014", VA = "0x8014")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000955")]
		public IndexButtonBasic InBankButton
		{
			[Token(Token = "0x6002FAF")]
			[Address(RVA = "0x8015", Offset = "0x8015", VA = "0x8015")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000956")]
		public RectTransform UniversalDarkBG
		{
			[Token(Token = "0x6002FB0")]
			[Address(RVA = "0x8016", Offset = "0x8016", VA = "0x8016")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000957")]
		public RectTransform ShopDarkBG
		{
			[Token(Token = "0x6002FB1")]
			[Address(RVA = "0x8017", Offset = "0x8017", VA = "0x8017")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000958")]
		public RectTransform WindowRect
		{
			[Token(Token = "0x6002FB2")]
			[Address(RVA = "0x8018", Offset = "0x8018", VA = "0x8018")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB3")]
		[Address(RVA = "0x8019", Offset = "0x8019", VA = "0x8019")]
		public FrescoEditView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Fresco_View_FrescoEditView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57559 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12617);
		    DAT_ram_00a57559 = '\x01';
		  }
		  return StringLiteral_12617;
		}
		*/

		}

		// Token: 0x040019E6 RID: 6630
		[Token(Token = "0x40019E6")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040019E7 RID: 6631
		[Token(Token = "0x40019E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _titleCounter;

		// Token: 0x040019E8 RID: 6632
		[Token(Token = "0x40019E8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private FrescoFieldEditable _frescoField;

		// Token: 0x040019E9 RID: 6633
		[Token(Token = "0x40019E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _keyObjectView;

		// Token: 0x040019EA RID: 6634
		[Token(Token = "0x40019EA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ArtikulView _keyArtikulView;

		// Token: 0x040019EB RID: 6635
		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FrescoFragment _keyFrescoFragment;

		// Token: 0x040019EC RID: 6636
		[Token(Token = "0x40019EC")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x040019ED RID: 6637
		[Token(Token = "0x40019ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _requirements;

		// Token: 0x040019EE RID: 6638
		[Token(Token = "0x40019EE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x040019EF RID: 6639
		[Token(Token = "0x40019EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LoaderValueRowView _additionalRequirements;

		// Token: 0x040019F0 RID: 6640
		[Token(Token = "0x40019F0")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _additionalRequirementsButton;

		// Token: 0x040019F1 RID: 6641
		[Token(Token = "0x40019F1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _selectedUniversalFragmentCounter;

		// Token: 0x040019F2 RID: 6642
		[Token(Token = "0x40019F2")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _universalFragmentCounter;

		// Token: 0x040019F3 RID: 6643
		[Token(Token = "0x40019F3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _installAndContinueInfo;

		// Token: 0x040019F4 RID: 6644
		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RectTransform _universalDarkBG;

		// Token: 0x040019F5 RID: 6645
		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _installUniversalButton;

		// Token: 0x040019F6 RID: 6646
		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Button _buyUniversalFragmentButton;

		// Token: 0x040019F7 RID: 6647
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _installAllUniversalButton;

		// Token: 0x040019F8 RID: 6648
		[Token(Token = "0x40019F8")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private BankOptionsListView _bankOptionsListView;

		// Token: 0x040019F9 RID: 6649
		[Token(Token = "0x40019F9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _shopDarkBG;

		// Token: 0x040019FA RID: 6650
		[Token(Token = "0x40019FA")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private IndexButtonBasic _inBankButton;

		// Token: 0x040019FB RID: 6651
		[Token(Token = "0x40019FB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _leftButton;

		// Token: 0x040019FC RID: 6652
		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Button _rightButton;

		// Token: 0x040019FD RID: 6653
		[Token(Token = "0x40019FD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _installAllButton;

		// Token: 0x040019FE RID: 6654
		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Button _completeFrescoButton;

		// Token: 0x040019FF RID: 6655
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _installAndContinueButton;

		// Token: 0x04001A00 RID: 6656
		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Button _acceptButton;

		// Token: 0x04001A01 RID: 6657
		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _collectRewardButton;

		// Token: 0x04001A02 RID: 6658
		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Button _closeTopButton;

		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _windowRect;

		// Token: 0x020007EC RID: 2028
		[Token(Token = "0x20007EC")]
		public enum States
		{
			// Token: 0x04001A05 RID: 6661
			[Token(Token = "0x4001A05")]
			None,
			// Token: 0x04001A06 RID: 6662
			[Token(Token = "0x4001A06")]
			PartlyFilled,
			// Token: 0x04001A07 RID: 6663
			[Token(Token = "0x4001A07")]
			FragmentSelected,
			// Token: 0x04001A08 RID: 6664
			[Token(Token = "0x4001A08")]
			InstallAndContinue,
			// Token: 0x04001A09 RID: 6665
			[Token(Token = "0x4001A09")]
			UniversalFragmentsInstallation,
			// Token: 0x04001A0A RID: 6666
			[Token(Token = "0x4001A0A")]
			BuyUniversalFragment,
			// Token: 0x04001A0B RID: 6667
			[Token(Token = "0x4001A0B")]
			Full,
			// Token: 0x04001A0C RID: 6668
			[Token(Token = "0x4001A0C")]
			Assembled,
			// Token: 0x04001A0D RID: 6669
			[Token(Token = "0x4001A0D")]
			Finished
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowRect ---
		void Gameplay_Fresco_View_FrescoEditView__get_WindowRect(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57558 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_FrescoEditView_States___ctor__);
		    DAT_ram_00a57558 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_FrescoEditView_States___ctor__);
		  return;
		}
		*/

}
