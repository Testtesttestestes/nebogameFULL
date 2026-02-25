using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.RegisterV2.Control;
using Gameplay.RegisterV2.Events;
using Gameplay.RegisterV2.Model;
using Gameplay.RegisterV2.View.CultSelector;
using Gameplay.RegisterV2.View.GenderSelector;
using Gameplay.Tutorial.Guide.View;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Filters.GenericFilter;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Utils;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x0200055E RID: 1374
	[Token(Token = "0x200055E")]
	public class RegistrationView : MonoBehaviour
	{
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060C")]
		public MonoPointerClickHandler ForegroundClick
		{
			[Token(Token = "0x6002104")]
			[Address(RVA = "0x7266", Offset = "0x7266", VA = "0x7266")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060D")]
		public DeselectableGenericFilterView Spells
		{
			[Token(Token = "0x6002105")]
			[Address(RVA = "0x7267", Offset = "0x7267", VA = "0x7267")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060E")]
		public RegistrationRewardsView Rewards
		{
			[Token(Token = "0x6002106")]
			[Address(RVA = "0x7268", Offset = "0x7268", VA = "0x7268")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060F")]
		public GraphicPointerView PointerView
		{
			[Token(Token = "0x6002107")]
			[Address(RVA = "0x7269", Offset = "0x7269", VA = "0x7269")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000610")]
		public TextMeshProUGUI CultDescription
		{
			[Token(Token = "0x6002108")]
			[Address(RVA = "0x726A", Offset = "0x726A", VA = "0x726A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000611")]
		public GameAssetViewRawImage AvatarView
		{
			[Token(Token = "0x6002109")]
			[Address(RVA = "0x726B", Offset = "0x726B", VA = "0x726B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000612")]
		public GenderSelector GenderSelector
		{
			[Token(Token = "0x600210A")]
			[Address(RVA = "0x726C", Offset = "0x726C", VA = "0x726C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000613")]
		public TextMeshProUGUI IncorrectNickMessage
		{
			[Token(Token = "0x600210B")]
			[Address(RVA = "0x726D", Offset = "0x726D", VA = "0x726D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000614")]
		public NickInputField NickInputSkin
		{
			[Token(Token = "0x600210C")]
			[Address(RVA = "0x726E", Offset = "0x726E", VA = "0x726E")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000140 RID: 320
		// (add) Token: 0x0600210D RID: 8461 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600210E RID: 8462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000140")]
		public event Action<CultDic> OnCultChanged
		{
			[Token(Token = "0x600210D")]
			[Address(RVA = "0x726F", Offset = "0x726F", VA = "0x726F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600210E")]
			[Address(RVA = "0x7270", Offset = "0x7270", VA = "0x7270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000141 RID: 321
		// (add) Token: 0x0600210F RID: 8463 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002110 RID: 8464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000141")]
		public event Action OnRegisterClicked
		{
			[Token(Token = "0x600210F")]
			[Address(RVA = "0x7271", Offset = "0x7271", VA = "0x7271")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002110")]
			[Address(RVA = "0x7272", Offset = "0x7272", VA = "0x7272")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000142 RID: 322
		// (add) Token: 0x06002111 RID: 8465 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002112 RID: 8466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000142")]
		public event Action<string, bool> OnNickStatusChanged
		{
			[Token(Token = "0x6002111")]
			[Address(RVA = "0x7273", Offset = "0x7273", VA = "0x7273")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002112")]
			[Address(RVA = "0x7274", Offset = "0x7274", VA = "0x7274")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000143 RID: 323
		// (add) Token: 0x06002113 RID: 8467 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002114 RID: 8468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000143")]
		public event Action<string> OnNickChanged
		{
			[Token(Token = "0x6002113")]
			[Address(RVA = "0x7275", Offset = "0x7275", VA = "0x7275")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002114")]
			[Address(RVA = "0x7276", Offset = "0x7276", VA = "0x7276")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000144 RID: 324
		// (add) Token: 0x06002115 RID: 8469 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002116 RID: 8470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000144")]
		public event Action OnSaveProgressClicked
		{
			[Token(Token = "0x6002115")]
			[Address(RVA = "0x7277", Offset = "0x7277", VA = "0x7277")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002116")]
			[Address(RVA = "0x7278", Offset = "0x7278", VA = "0x7278")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000145 RID: 325
		// (add) Token: 0x06002117 RID: 8471 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002118 RID: 8472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000145")]
		public event Action OnGenerateNick
		{
			[Token(Token = "0x6002117")]
			[Address(RVA = "0x7279", Offset = "0x7279", VA = "0x7279")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002118")]
			[Address(RVA = "0x727A", Offset = "0x727A", VA = "0x727A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000146 RID: 326
		// (add) Token: 0x06002119 RID: 8473 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000146")]
		public event Action OnRegistrationComplete
		{
			[Token(Token = "0x6002119")]
			[Address(RVA = "0x727B", Offset = "0x727B", VA = "0x727B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600211A")]
			[Address(RVA = "0x727C", Offset = "0x727C", VA = "0x727C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x727D", Offset = "0x727D", VA = "0x727D")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x727E", Offset = "0x727E", VA = "0x727E")]
		private void Awake()
		{
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x727F", Offset = "0x727F", VA = "0x727F")]
		private void Start()
		{
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x7280", Offset = "0x7280", VA = "0x7280")]
		private void SpellsAndCultDescriptionPanelOnCurrentStateChangedEvent(SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState fromstate, SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState tostate)
		{
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x7281", Offset = "0x7281", VA = "0x7281")]
		private void HandleSpellDeselect()
		{
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x7282", Offset = "0x7282", VA = "0x7282")]
		private void HandleSpellSelected(object obj)
		{
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x7283", Offset = "0x7283", VA = "0x7283")]
		private void ShowRewardsPopup()
		{
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x7284", Offset = "0x7284", VA = "0x7284")]
		private void RightArrowClick()
		{
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x7285", Offset = "0x7285", VA = "0x7285")]
		private void LeftArrowClick()
		{
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x7286", Offset = "0x7286", VA = "0x7286")]
		private void InitMVC()
		{
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x7287", Offset = "0x7287", VA = "0x7287")]
		private void OnRegistrationProcessCompleteEvent()
		{
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x7288", Offset = "0x7288", VA = "0x7288")]
		private void DisposeMVC()
		{
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x7289", Offset = "0x7289", VA = "0x7289")]
		public void SetCults(List<CultDic> value)
		{
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x728A", Offset = "0x728A", VA = "0x728A")]
		public void SelectCult(uint cultId)
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x728B", Offset = "0x728B", VA = "0x728B")]
		private void SelectCult(int index)
		{
		}

		// Token: 0x17000615 RID: 1557
		// (set) Token: 0x0600212A RID: 8490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000615")]
		public string CurrentNick
		{
			[Token(Token = "0x600212A")]
			[Address(RVA = "0x728C", Offset = "0x728C", VA = "0x728C")]
			set
			{
			}
		}

		// Token: 0x17000616 RID: 1558
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000616")]
		public string NickPattern
		{
			[Token(Token = "0x600212B")]
			[Address(RVA = "0x728D", Offset = "0x728D", VA = "0x728D")]
			set
			{
			}
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212C")]
		[Address(RVA = "0x728E", Offset = "0x728E", VA = "0x728E")]
		private void OnNickStatusChangedListener(bool status)
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x728F", Offset = "0x728F", VA = "0x728F")]
		private void PutOutNickInputField()
		{
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212E")]
		[Address(RVA = "0x7290", Offset = "0x7290", VA = "0x7290")]
		private void LightUpNickInputFiled(in Color color)
		{
		}

		// Token: 0x17000617 RID: 1559
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000617")]
		public bool NickInputStatus
		{
			[Token(Token = "0x600212F")]
			[Address(RVA = "0x7291", Offset = "0x7291", VA = "0x7291")]
			set
			{
			}
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x7292", Offset = "0x7292", VA = "0x7292")]
		private void OnRegisterButtonClicked()
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x7293", Offset = "0x7293", VA = "0x7293")]
		private void OnCultSelected(CultListElementArgs args)
		{
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x7294", Offset = "0x7294", VA = "0x7294")]
		private void OnEndEditNick(string nick)
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002133")]
		[Address(RVA = "0x7295", Offset = "0x7295", VA = "0x7295")]
		private void OnGenerateNickClicked()
		{
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002134")]
		[Address(RVA = "0x7296", Offset = "0x7296", VA = "0x7296")]
		private void OnCultDeselect(CultListElementArgs args)
		{
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002135")]
		[Address(RVA = "0x7297", Offset = "0x7297", VA = "0x7297")]
		public void SetEnableIncorrectNickMessage(bool value)
		{
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002136")]
		[Address(RVA = "0x7298", Offset = "0x7298", VA = "0x7298")]
		public void SetSpells(IEnumerable<SpellDic> spells)
		{
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002137")]
		[Address(RVA = "0x7299", Offset = "0x7299", VA = "0x7299")]
		public void SetPointerActive(bool value)
		{
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002138")]
		[Address(RVA = "0x729A", Offset = "0x729A", VA = "0x729A")]
		public void SetRegisterButtonActive(bool value)
		{
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002139")]
		[Address(RVA = "0x729B", Offset = "0x729B", VA = "0x729B")]
		public void SetGenerateNickButtonActive(bool value)
		{
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213A")]
		[Address(RVA = "0x729C", Offset = "0x729C", VA = "0x729C")]
		public void ShowPointerOnGenerateButton()
		{
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213B")]
		[Address(RVA = "0x729D", Offset = "0x729D", VA = "0x729D")]
		public void ShowPointerOnRegisterButton()
		{
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600213C")]
		[Address(RVA = "0x729E", Offset = "0x729E", VA = "0x729E")]
		private FilterWithIconListElement.FilterWithIconData ConstructArgs(SpellDic dic)
		{
			return null;
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x729F", Offset = "0x729F", VA = "0x729F")]
		public RegistrationView()
		{
		}

		// Token: 0x04001207 RID: 4615
		[Token(Token = "0x4001207")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("_cultSectorList")]
		[SerializeField]
		private CultSectorList _cultList;

		// Token: 0x04001208 RID: 4616
		[Token(Token = "0x4001208")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private PatternTextInput _nickInput;

		// Token: 0x04001209 RID: 4617
		[Token(Token = "0x4001209")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _registerButton;

		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x400120A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _generateNickButton;

		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400120B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _leftArrowButton;

		// Token: 0x0400120C RID: 4620
		[Token(Token = "0x400120C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _rightArrowButton;

		// Token: 0x0400120D RID: 4621
		[Token(Token = "0x400120D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GenderSelector _genderSelector;

		// Token: 0x0400120E RID: 4622
		[Token(Token = "0x400120E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameAssetViewRawImage _avatarView;

		// Token: 0x0400120F RID: 4623
		[Token(Token = "0x400120F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DeselectableGenericFilterView _spells;

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private CultsFade _cultsFader;

		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001211")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _incorrectNickMessage;

		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001212")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _cultDescription;

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private NickInputField _nickInputSkin;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GraphicPointerView _pointerView;

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001215")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameAnimationView _pointerAnimation;

		// Token: 0x04001216 RID: 4630
		[Token(Token = "0x4001216")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color _warnColorForNickINputField;

		// Token: 0x04001217 RID: 4631
		[Token(Token = "0x4001217")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private RegistrationRewardsView _rewardsView;

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001218")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _rewardButton;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private RegistrationTitleDescription _spellTitleDescription;

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x400121A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MonoPointerClickHandler _foregroundClick;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private SpellsAndCultDescriptionPanel _spellsAndCultDescriptionPanel;

		// Token: 0x04001223 RID: 4643
		[Token(Token = "0x4001223")]
		[FieldOffset(Offset = "0x8C")]
		private RegisterEvents _events;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[FieldOffset(Offset = "0x90")]
		private RegisterModel _model;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[FieldOffset(Offset = "0x94")]
		private RegisterController _controller;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0x98")]
		private RegisterMediator _mediator;
	}
}
