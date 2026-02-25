using System;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View.DailyRewards
{
	// Token: 0x02000530 RID: 1328
	[Token(Token = "0x2000530")]
	public class RewardsTab : MonoBehaviourWithStates<RewardsTab.State>, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C6")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001F98")]
			[Address(RVA = "0x70FD", Offset = "0x70FD", VA = "0x70FD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C7")]
		public CounterAutoHide RedCounter
		{
			[Token(Token = "0x6001F99")]
			[Address(RVA = "0x70FE", Offset = "0x70FE", VA = "0x70FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C8")]
		public TextMeshProUGUI StatusText
		{
			[Token(Token = "0x6001F9A")]
			[Address(RVA = "0x70FF", Offset = "0x70FF", VA = "0x70FF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C9")]
		public Button Button
		{
			[Token(Token = "0x6001F9B")]
			[Address(RVA = "0x7100", Offset = "0x7100", VA = "0x7100")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x00006690 File Offset: 0x00004890
		// (set) Token: 0x06001F9D RID: 8093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CA")]
		public bool Selected
		{
			[Token(Token = "0x6001F9C")]
			[Address(RVA = "0x7101", Offset = "0x7101", VA = "0x7101")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F9D")]
			[Address(RVA = "0x7102", Offset = "0x7102", VA = "0x7102")]
			set
			{
			}
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0x7103", Offset = "0x7103", VA = "0x7103")]
		public void Init(RectTransform activeParent, RectTransform inactiveParent)
		{
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0x7104", Offset = "0x7104", VA = "0x7104", Slot = "4")]
		protected override void HandleCurrentStateChanged(RewardsTab.State fromState, RewardsTab.State toState)
		{
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x7105", Offset = "0x7105", VA = "0x7105", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x7106", Offset = "0x7106", VA = "0x7106", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x7107", Offset = "0x7107", VA = "0x7107")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x7108", Offset = "0x7108", VA = "0x7108")]
		private void AnimateAlpha(Image target, float endValue, ref Tweener tweener)
		{
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0x7109", Offset = "0x7109", VA = "0x7109")]
		private void AnimatePosition(bool enable)
		{
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0x710A", Offset = "0x710A", VA = "0x710A")]
		private void ChangeParent(bool enable)
		{
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0x710B", Offset = "0x710B", VA = "0x710B")]
		private void Highlight()
		{
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0x710C", Offset = "0x710C", VA = "0x710C")]
		private void TurnOff()
		{
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x710D", Offset = "0x710D", VA = "0x710D")]
		private void TweenSelect()
		{
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0x710E", Offset = "0x710E", VA = "0x710E")]
		private void TweenDeselect()
		{
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x710F", Offset = "0x710F", VA = "0x710F")]
		private void StartGlowing()
		{
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x7110", Offset = "0x7110", VA = "0x7110")]
		public RewardsTab()
		{
		}

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		private const float TRANSITION_TIME = 0.5f;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		private const float GLOW_TIME = 1f;

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		private const float X_SHIFT = -90f;

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _selector;

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _lineSelector;

		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x400114F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001150 RID: 4432
		[Token(Token = "0x4001150")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private CounterAutoHide _redCounter;

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _status;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x34")]
		private RectTransform _activeParent;

		// Token: 0x04001154 RID: 4436
		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform _inactiveParent;

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _startPosition;

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x48")]
		private bool _selected;

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x4C")]
		private Tweener _lineTweener;

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x50")]
		private Tweener _selectorTweener;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x54")]
		private Sequence _moveSequence;

		// Token: 0x02000531 RID: 1329
		[Token(Token = "0x2000531")]
		public enum State
		{
			// Token: 0x0400115B RID: 4443
			[Token(Token = "0x400115B")]
			INACTIVE,
			// Token: 0x0400115C RID: 4444
			[Token(Token = "0x400115C")]
			HIGHLIGHTED,
			// Token: 0x0400115D RID: 4445
			[Token(Token = "0x400115D")]
			SELECTED
		}
	}
}
