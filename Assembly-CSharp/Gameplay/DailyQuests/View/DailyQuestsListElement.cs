using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.GenericList;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000873 RID: 2163
	[Token(Token = "0x2000873")]
	public class DailyQuestsListElement : SelectedGenericListElement<DailyQuestsListElementArgs>
	{
		// Token: 0x060032C9 RID: 13001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C9")]
		[Address(RVA = "0x831B", Offset = "0x831B", VA = "0x831B")]
		private void Awake()
		{
		}

		// Token: 0x17000A02 RID: 2562
		// (set) Token: 0x060032CA RID: 13002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A02")]
		private DailyQuestsListElementArgs Args
		{
			[Token(Token = "0x60032CA")]
			[Address(RVA = "0x831C", Offset = "0x831C", VA = "0x831C")]
			set
			{
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060032CB RID: 13003 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060032CC RID: 13004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A03")]
		public DailyQuestsListElementArgs Data
		{
			[Token(Token = "0x60032CB")]
			[Address(RVA = "0x831D", Offset = "0x831D", VA = "0x831D")]
			get
			{
				return null;
			}
			[Token(Token = "0x60032CC")]
			[Address(RVA = "0x831E", Offset = "0x831E", VA = "0x831E")]
			set
			{
			}
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CD")]
		[Address(RVA = "0x831F", Offset = "0x831F", VA = "0x831F")]
		public void Release()
		{
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CE")]
		[Address(RVA = "0x8320", Offset = "0x8320", VA = "0x8320", Slot = "4")]
		protected override void OnInit(DailyQuestsListElementArgs args)
		{
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CF")]
		[Address(RVA = "0x8321", Offset = "0x8321", VA = "0x8321")]
		private void ApplyArgs()
		{
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D0")]
		[Address(RVA = "0x8322", Offset = "0x8322", VA = "0x8322")]
		private void DrawBackgroundImage()
		{
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D1")]
		[Address(RVA = "0x8323", Offset = "0x8323", VA = "0x8323")]
		private void ResolveState()
		{
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D2")]
		[Address(RVA = "0x8324", Offset = "0x8324", VA = "0x8324")]
		private void ResolveQuestType()
		{
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D3")]
		[Address(RVA = "0x8325", Offset = "0x8325", VA = "0x8325", Slot = "5")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D4")]
		[Address(RVA = "0x8326", Offset = "0x8326", VA = "0x8326", Slot = "6")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D5")]
		[Address(RVA = "0x8327", Offset = "0x8327", VA = "0x8327")]
		private void OnClickEventHandler(DailyQuestsListElementArgs args)
		{
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D6")]
		[Address(RVA = "0x8328", Offset = "0x8328", VA = "0x8328")]
		private void TakeButtonClickedEventHandler()
		{
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D7")]
		[Address(RVA = "0x8329", Offset = "0x8329", VA = "0x8329")]
		private void OnDestroy()
		{
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D8")]
		[Address(RVA = "0x832A", Offset = "0x832A", VA = "0x832A")]
		private void QuestionButtonClickedEventHandler()
		{
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D9")]
		[Address(RVA = "0x832B", Offset = "0x832B", VA = "0x832B")]
		private void BeginButtonClickedEventHandler()
		{
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032DA")]
		[Address(RVA = "0x832C", Offset = "0x832C", VA = "0x832C")]
		private void WatchButtonClickedEventHandler()
		{
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60032DB")]
		[Address(RVA = "0x832D", Offset = "0x832D", VA = "0x832D")]
		private string FormatBackTime(float backtime)
		{
			return null;
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032DC")]
		[Address(RVA = "0x832E", Offset = "0x832E", VA = "0x832E")]
		public DailyQuestsListElement()
		{
		}

		// Token: 0x04001BC8 RID: 7112
		[Token(Token = "0x4001BC8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _name;

		// Token: 0x04001BC9 RID: 7113
		[Token(Token = "0x4001BC9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameImageLoader _backgroundImageLoader;

		// Token: 0x04001BCA RID: 7114
		[Token(Token = "0x4001BCA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _defaultBackground;

		// Token: 0x04001BCB RID: 7115
		[Token(Token = "0x4001BCB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameRawImageLoader _someImageLoader;

		// Token: 0x04001BCC RID: 7116
		[Token(Token = "0x4001BCC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04001BCD RID: 7117
		[Token(Token = "0x4001BCD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _takeButton;

		// Token: 0x04001BCE RID: 7118
		[Token(Token = "0x4001BCE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _taskComplete;

		// Token: 0x04001BCF RID: 7119
		[Token(Token = "0x4001BCF")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04001BD0 RID: 7120
		[Token(Token = "0x4001BD0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _questionButton;

		// Token: 0x04001BD1 RID: 7121
		[Token(Token = "0x4001BD1")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _beginButton;

		// Token: 0x04001BD2 RID: 7122
		[Token(Token = "0x4001BD2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _watchButton;
	}
}
