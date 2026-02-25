using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Gameplay.GameEvents.View.ActionsOnEvens;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.GameEvents.View
{
	// Token: 0x02000775 RID: 1909
	[Token(Token = "0x2000775")]
	public class ActionsOnEventBox : MonoBehaviour
	{
		// Token: 0x14000164 RID: 356
		// (add) Token: 0x06002D7F RID: 11647 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002D80 RID: 11648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000164")]
		public event EventHandler<AbstractActionOnEvent> OnActionTriggeredEvent
		{
			[Token(Token = "0x6002D7F")]
			[Address(RVA = "0x7DFD", Offset = "0x7DFD", VA = "0x7DFD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D80")]
			[Address(RVA = "0x7DFE", Offset = "0x7DFE", VA = "0x7DFE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D81")]
		[Address(RVA = "0x7DFF", Offset = "0x7DFF", VA = "0x7DFF")]
		public ActionsOnEventBox.ActionsPrefabConfig GetConfig(EventActionDic.Types.BehaviorTypes type)
		{
			return null;
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D82")]
		[Address(RVA = "0x7E00", Offset = "0x7E00", VA = "0x7E00")]
		public ActionsOnEventBox.ActionViewPlaceHolder GetPlaceHolder(EventActionDic.Types.BehaviorTypes type)
		{
			return null;
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008BA")]
		public List<AbstractActionOnEvent> ActionsOnEvent
		{
			[Token(Token = "0x6002D83")]
			[Address(RVA = "0x7E01", Offset = "0x7E01", VA = "0x7E01")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D84")]
			[Address(RVA = "0x7E02", Offset = "0x7E02", VA = "0x7E02")]
			set
			{
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x7E03", Offset = "0x7E03", VA = "0x7E03")]
		private void handleActionOnEventChanged()
		{
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D86")]
		[Address(RVA = "0x7E04", Offset = "0x7E04", VA = "0x7E04")]
		private void HandleOnTriggeredEvent(object sender, AbstractActionOnEvent data)
		{
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D87")]
		[Address(RVA = "0x7E05", Offset = "0x7E05", VA = "0x7E05")]
		public ActionsOnEventBox()
		{
		}

		// Token: 0x040018E1 RID: 6369
		[Token(Token = "0x40018E1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ActionsOnEventBox.ActionsPrefabConfig[] _viewPrefabs;

		// Token: 0x040018E2 RID: 6370
		[Token(Token = "0x40018E2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ActionsOnEventBox.ActionViewPlaceHolder[] _actionViewsPlaceholders;

		// Token: 0x040018E4 RID: 6372
		[Token(Token = "0x40018E4")]
		[FieldOffset(Offset = "0x1C")]
		public List<AbstractActionOnEvent> _actionsOnEvent;

		// Token: 0x02000776 RID: 1910
		[Token(Token = "0x2000776")]
		[Serializable]
		public class ActionsPrefabConfig
		{
			// Token: 0x06002D88 RID: 11656 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D88")]
			[Address(RVA = "0x7E06", Offset = "0x7E06", VA = "0x7E06")]
			public ActionsPrefabConfig()
			{
			}

			// Token: 0x040018E5 RID: 6373
			[Token(Token = "0x40018E5")]
			[FieldOffset(Offset = "0x8")]
			public EventActionDic.Types.BehaviorTypes BehaviorType;

			// Token: 0x040018E6 RID: 6374
			[Token(Token = "0x40018E6")]
			[FieldOffset(Offset = "0xC")]
			public AbstractActionOnEventView ViewPrefab;
		}

		// Token: 0x02000777 RID: 1911
		[Token(Token = "0x2000777")]
		[Serializable]
		public class ActionViewPlaceHolder
		{
			// Token: 0x06002D89 RID: 11657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D89")]
			[Address(RVA = "0x7E07", Offset = "0x7E07", VA = "0x7E07")]
			public ActionViewPlaceHolder()
			{
			}

			// Token: 0x040018E7 RID: 6375
			[Token(Token = "0x40018E7")]
			[FieldOffset(Offset = "0x8")]
			public EventActionDic.Types.BehaviorTypes BehaviorType;

			// Token: 0x040018E8 RID: 6376
			[Token(Token = "0x40018E8")]
			[FieldOffset(Offset = "0xC")]
			public Transform Parent;
		}
	}
}
