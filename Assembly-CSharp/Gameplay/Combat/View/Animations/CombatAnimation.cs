using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x0200097C RID: 2428
	[Token(Token = "0x200097C")]
	public class CombatAnimation : ICombatAnimation, IDisposable
	{
		// Token: 0x14000185 RID: 389
		// (add) Token: 0x060039CC RID: 14796 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060039CD RID: 14797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000185")]
		public event Action<CombatAnimation.IContent> OnAnimExecuteEvent
		{
			[Token(Token = "0x60039CC")]
			[Address(RVA = "0x8959", Offset = "0x8959", VA = "0x8959", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60039CD")]
			[Address(RVA = "0x895A", Offset = "0x895A", VA = "0x895A", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B58")]
		public bool ScreenConvIsPause
		{
			[Token(Token = "0x60039CE")]
			[Address(RVA = "0x895B", Offset = "0x895B", VA = "0x895B")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039CF")]
			[Address(RVA = "0x895C", Offset = "0x895C", VA = "0x895C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060039D1 RID: 14801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B59")]
		public Conveyor ScreenConv
		{
			[Token(Token = "0x60039D0")]
			[Address(RVA = "0x895D", Offset = "0x895D", VA = "0x895D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60039D1")]
			[Address(RVA = "0x895E", Offset = "0x895E", VA = "0x895E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		// (set) Token: 0x060039D3 RID: 14803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5A")]
		public bool IsDisposed
		{
			[Token(Token = "0x60039D2")]
			[Address(RVA = "0x895F", Offset = "0x895F", VA = "0x895F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039D3")]
			[Address(RVA = "0x8960", Offset = "0x8960", VA = "0x8960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D4")]
		[Address(RVA = "0x8961", Offset = "0x8961", VA = "0x8961")]
		private void ScreenConvPause()
		{
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D5")]
		[Address(RVA = "0x8962", Offset = "0x8962", VA = "0x8962")]
		private void ScreenConvResume()
		{
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D6")]
		[Address(RVA = "0x1CB1", Offset = "0x1CB1", VA = "0x1CB1")]
		public CombatAnimation(CombatAnimationCounter animationCounter, Transform parent, int sortingOrder)
		{
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D7")]
		[Address(RVA = "0x8963", Offset = "0x8963", VA = "0x8963")]
		private void ScreenAnimCompleteQueueCallback()
		{
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D8")]
		[Address(RVA = "0x8964", Offset = "0x8964", VA = "0x8964")]
		private void ScreenAnimExecuteCallback(IConveyorItem convItem)
		{
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D9")]
		[Address(RVA = "0x8965", Offset = "0x8965", VA = "0x8965")]
		private void HandleScreenAnimationOnCompleteEvent(CombatAnimation.IContent content)
		{
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x8966", Offset = "0x8966", VA = "0x8966", Slot = "6")]
		public OpToken<CombatAnimation.IContent, CombatAnimation.IContent> Load(string path)
		{
			return null;
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x8967", Offset = "0x8967", VA = "0x8967", Slot = "7")]
		public void Append(string path, bool isLeft)
		{
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DC")]
		[Address(RVA = "0x8968", Offset = "0x8968", VA = "0x8968", Slot = "8")]
		public void Append(CombatAnimation.IContent content)
		{
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DD")]
		[Address(RVA = "0x8969", Offset = "0x8969", VA = "0x8969")]
		private void HandleLoadFail(OpToken<CombatAnimation.IContent, CombatAnimation.IContent> op)
		{
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DE")]
		[Address(RVA = "0x896A", Offset = "0x896A", VA = "0x896A")]
		private void HandleLoadSuccess(OpToken<CombatAnimation.IContent, CombatAnimation.IContent> op)
		{
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x896B", Offset = "0x896B", VA = "0x896B", Slot = "9")]
		public void CancelLoad()
		{
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x896C", Offset = "0x896C", VA = "0x896C", Slot = "10")]
		public void Stop()
		{
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x896D", Offset = "0x896D", VA = "0x896D", Slot = "11")]
		public void Reset()
		{
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E2")]
		[Address(RVA = "0x896E", Offset = "0x896E", VA = "0x896E", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x04001FFD RID: 8189
		[Token(Token = "0x4001FFD")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<string, OpToken<CombatAnimation.IContent, CombatAnimation.IContent>> _cache;

		// Token: 0x04001FFE RID: 8190
		[Token(Token = "0x4001FFE")]
		[FieldOffset(Offset = "0x10")]
		private readonly LinkedList<OpToken<CombatAnimation.IContent, CombatAnimation.IContent>> _awaitingLoad;

		// Token: 0x04002002 RID: 8194
		[Token(Token = "0x4002002")]
		[FieldOffset(Offset = "0x20")]
		private Transform _parent;

		// Token: 0x04002003 RID: 8195
		[Token(Token = "0x4002003")]
		[FieldOffset(Offset = "0x24")]
		private CombatAnimationCounter _animationCounter;

		// Token: 0x04002004 RID: 8196
		[Token(Token = "0x4002004")]
		[FieldOffset(Offset = "0x28")]
		public readonly int SortingOrder;

		// Token: 0x0200097D RID: 2429
		[Token(Token = "0x200097D")]
		public interface IContent : IDisposable
		{
			// Token: 0x14000186 RID: 390
			// (add) Token: 0x060039E3 RID: 14819
			// (remove) Token: 0x060039E4 RID: 14820
			[Token(Token = "0x14000186")]
			event Action<CombatAnimation.IContent> OnCompleteEvent;

			// Token: 0x060039E5 RID: 14821
			[Token(Token = "0x60039E5")]
			void Show();

			// Token: 0x060039E6 RID: 14822
			[Token(Token = "0x60039E6")]
			void Hide();

			// Token: 0x060039E7 RID: 14823
			[Token(Token = "0x60039E7")]
			void Play(bool loop);

			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x060039E8 RID: 14824
			[Token(Token = "0x17000B5B")]
			Transform Transform { [Token(Token = "0x60039E8")] get; }

			// Token: 0x17000B5C RID: 2908
			// (get) Token: 0x060039E9 RID: 14825
			// (set) Token: 0x060039EA RID: 14826
			[Token(Token = "0x17000B5C")]
			bool IsLeft { [Token(Token = "0x60039E9")] get; [Token(Token = "0x60039EA")] set; }
		}

		// Token: 0x0200097E RID: 2430
		[Token(Token = "0x200097E")]
		private class AnimationConvItem : IConveyorItem
		{
			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x060039EB RID: 14827 RVA: 0x0000B8E0 File Offset: 0x00009AE0
			[Token(Token = "0x17000B5D")]
			public float Duration
			{
				[Token(Token = "0x60039EB")]
				[Address(RVA = "0x896F", Offset = "0x896F", VA = "0x896F", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x060039EC RID: 14828 RVA: 0x0000B8F8 File Offset: 0x00009AF8
			[Token(Token = "0x17000B5E")]
			public float Delay
			{
				[Token(Token = "0x60039EC")]
				[Address(RVA = "0x8970", Offset = "0x8970", VA = "0x8970", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060039ED RID: 14829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039ED")]
			[Address(RVA = "0x8971", Offset = "0x8971", VA = "0x8971")]
			public AnimationConvItem(CombatAnimation.IContent content, float duration, float delay)
			{
			}

			// Token: 0x04002007 RID: 8199
			[Token(Token = "0x4002007")]
			[FieldOffset(Offset = "0x10")]
			public readonly CombatAnimation.IContent Content;
		}
	}
}
