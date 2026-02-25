using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Chat.View.Messages
{
	// Token: 0x02000AFA RID: 2810
	[Token(Token = "0x2000AFA")]
	public class ChatMiniMessagesCarousel : MonoBehaviour
	{
		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x17000D5D")]
		public int MAXCount
		{
			[Token(Token = "0x60043C3")]
			[Address(RVA = "0x9276", Offset = "0x9276", VA = "0x9276")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C4")]
		[Address(RVA = "0x9277", Offset = "0x9277", VA = "0x9277")]
		private void OnDestroy()
		{
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60043C5")]
		[Address(RVA = "0x9278", Offset = "0x9278", VA = "0x9278")]
		private GameObjectPool<ChatMiniMessageRenderer> GetPool()
		{
			return null;
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C6")]
		[Address(RVA = "0x9279", Offset = "0x9279", VA = "0x9279")]
		public void Clear()
		{
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x60043C7")]
		[Address(RVA = "0x927A", Offset = "0x927A", VA = "0x927A")]
		public float GetMoveDuration()
		{
			return 0f;
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C8")]
		[Address(RVA = "0x927B", Offset = "0x927B", VA = "0x927B")]
		public void AddMessage(params string[] texts)
		{
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C9")]
		[Address(RVA = "0x927C", Offset = "0x927C", VA = "0x927C")]
		private void HandleQueues(Queue<string> awaitMessages, LinkedList<ChatMiniMessageRenderer> displayed, float duration)
		{
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CA")]
		[Address(RVA = "0x927D", Offset = "0x927D", VA = "0x927D")]
		private void ResetPoolObjectDelegate(ChatMiniMessageRenderer pooledobject)
		{
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CB")]
		[Address(RVA = "0x927E", Offset = "0x927E", VA = "0x927E")]
		public ChatMiniMessagesCarousel()
		{
		}

		// Token: 0x04002555 RID: 9557
		[Token(Token = "0x4002555")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _messagesContainer;

		// Token: 0x04002556 RID: 9558
		[Token(Token = "0x4002556")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ChatMiniMessageRenderer _messagePrefab;

		// Token: 0x04002557 RID: 9559
		[Token(Token = "0x4002557")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _maxCount;

		// Token: 0x04002558 RID: 9560
		[Token(Token = "0x4002558")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector2 _spawnPoint;

		// Token: 0x04002559 RID: 9561
		[Token(Token = "0x4002559")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector2 _destroyPoint;

		// Token: 0x0400255A RID: 9562
		[Token(Token = "0x400255A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _moveDuration;

		// Token: 0x0400255B RID: 9563
		[Token(Token = "0x400255B")]
		[FieldOffset(Offset = "0x30")]
		private GameObjectPool<ChatMiniMessageRenderer> _messagesPool;

		// Token: 0x0400255C RID: 9564
		[Token(Token = "0x400255C")]
		[FieldOffset(Offset = "0x34")]
		private LinkedList<ChatMiniMessageRenderer> _displayedMessages;

		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		[FieldOffset(Offset = "0x38")]
		private Queue<string> _awaitMessages;
	}
}
