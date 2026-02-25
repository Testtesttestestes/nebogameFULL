using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.Chat.View.Smiles
{
	// Token: 0x02000AF8 RID: 2808
	[Token(Token = "0x2000AF8")]
	public class SmilesView : MonoBehaviourWithStates<SmilesViewStates>
	{
		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D5A")]
		public SmileItemView SmilePrefab
		{
			[Token(Token = "0x60043B4")]
			[Address(RVA = "0x9267", Offset = "0x9267", VA = "0x9267")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001A6 RID: 422
		// (add) Token: 0x060043B5 RID: 17333 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043B6 RID: 17334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A6")]
		public event Action<ChatSmileDic> ItemSelectedEvent
		{
			[Token(Token = "0x60043B5")]
			[Address(RVA = "0x9268", Offset = "0x9268", VA = "0x9268")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043B6")]
			[Address(RVA = "0x9269", Offset = "0x9269", VA = "0x9269")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043B8 RID: 17336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5B")]
		public RepeatedField<ChatSmileDic> Smiles
		{
			[Token(Token = "0x60043B7")]
			[Address(RVA = "0x926A", Offset = "0x926A", VA = "0x926A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043B8")]
			[Address(RVA = "0x926B", Offset = "0x926B", VA = "0x926B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B9")]
		[Address(RVA = "0x926C", Offset = "0x926C", VA = "0x926C")]
		private void OnEnable()
		{
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BA")]
		[Address(RVA = "0x926D", Offset = "0x926D", VA = "0x926D")]
		private void OnDestroy()
		{
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BB")]
		[Address(RVA = "0x926E", Offset = "0x926E", VA = "0x926E")]
		private void Start()
		{
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x926F", Offset = "0x926F", VA = "0x926F")]
		private void ItemClickHandler(PointerEventData evtData)
		{
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BD")]
		[Address(RVA = "0x9270", Offset = "0x9270", VA = "0x9270", Slot = "4")]
		protected override void HandleCurrentStateChanged(SmilesViewStates fromState, SmilesViewStates toState)
		{
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BE")]
		[Address(RVA = "0x9271", Offset = "0x9271", VA = "0x9271")]
		public SmilesView()
		{
		}

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _content;

		// Token: 0x0400254C RID: 9548
		[Token(Token = "0x400254C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _movingContent;

		// Token: 0x0400254D RID: 9549
		[Token(Token = "0x400254D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _rolleupToExpandDuration;

		// Token: 0x0400254E RID: 9550
		[Token(Token = "0x400254E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SmileItemView _smilePrefab;

		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[FieldOffset(Offset = "0x2C")]
		[NonSerialized]
		private Vector2 _rolledUpPosition;

		// Token: 0x04002552 RID: 9554
		[Token(Token = "0x4002552")]
		[FieldOffset(Offset = "0x3C")]
		private List<SmileItemView> _views;

		// Token: 0x04002553 RID: 9555
		[Token(Token = "0x4002553")]
		[FieldOffset(Offset = "0x40")]
		private TweenContainer _tweenContainer;
	}
}
