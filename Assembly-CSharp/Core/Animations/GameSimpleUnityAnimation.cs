using System;
using System.Runtime.CompilerServices;
using Core.Materials;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Animations
{
	// Token: 0x0200127A RID: 4730
	[Token(Token = "0x200127A")]
	public class GameSimpleUnityAnimation : MonoBehaviour, IGameAnimation, IGrayscalable
	{
		// Token: 0x140002FD RID: 765
		// (add) Token: 0x06007046 RID: 28742 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007047 RID: 28743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002FD")]
		public event Action<IGameAnimation> ClickEvent
		{
			[Token(Token = "0x6007046")]
			[Address(RVA = "0xBA8B", Offset = "0xBA8B", VA = "0xBA8B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007047")]
			[Address(RVA = "0xBA8C", Offset = "0xBA8C", VA = "0xBA8C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06007048 RID: 28744 RVA: 0x00014610 File Offset: 0x00012810
		// (set) Token: 0x06007049 RID: 28745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016E9")]
		public bool Interactable
		{
			[Token(Token = "0x6007048")]
			[Address(RVA = "0xBA8D", Offset = "0xBA8D", VA = "0xBA8D", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007049")]
			[Address(RVA = "0xBA8E", Offset = "0xBA8E", VA = "0xBA8E", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x0600704A RID: 28746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016EA")]
		public MonoBehaviour MonoBehaviour
		{
			[Token(Token = "0x600704A")]
			[Address(RVA = "0xBA8F", Offset = "0xBA8F", VA = "0xBA8F", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x0600704B RID: 28747 RVA: 0x00014628 File Offset: 0x00012828
		// (set) Token: 0x0600704C RID: 28748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016EB")]
		public int SortingLayerId
		{
			[Token(Token = "0x600704B")]
			[Address(RVA = "0xBA90", Offset = "0xBA90", VA = "0xBA90", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600704C")]
			[Address(RVA = "0xBA91", Offset = "0xBA91", VA = "0xBA91", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x0600704D RID: 28749 RVA: 0x00014640 File Offset: 0x00012840
		// (set) Token: 0x0600704E RID: 28750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016EC")]
		public int SortingOrder
		{
			[Token(Token = "0x600704D")]
			[Address(RVA = "0xBA92", Offset = "0xBA92", VA = "0xBA92", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600704E")]
			[Address(RVA = "0xBA93", Offset = "0xBA93", VA = "0xBA93", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x140002FE RID: 766
		// (add) Token: 0x0600704F RID: 28751 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007050 RID: 28752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002FE")]
		public event Action<IGameAnimation> CompleteEvent
		{
			[Token(Token = "0x600704F")]
			[Address(RVA = "0xBA94", Offset = "0xBA94", VA = "0xBA94", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007050")]
			[Address(RVA = "0xBA95", Offset = "0xBA95", VA = "0xBA95", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007051")]
		[Address(RVA = "0xBA96", Offset = "0xBA96", VA = "0xBA96", Slot = "16")]
		public void Play(bool loop)
		{
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007052")]
		[Address(RVA = "0xBA97", Offset = "0xBA97", VA = "0xBA97", Slot = "17")]
		public void Stop()
		{
		}

		// Token: 0x06007053 RID: 28755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007053")]
		[Address(RVA = "0xBA98", Offset = "0xBA98", VA = "0xBA98", Slot = "19")]
		public void Pause()
		{
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06007054 RID: 28756 RVA: 0x00014658 File Offset: 0x00012858
		// (set) Token: 0x06007055 RID: 28757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016ED")]
		public bool Loop
		{
			[Token(Token = "0x6007054")]
			[Address(RVA = "0xBA99", Offset = "0xBA99", VA = "0xBA99", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007055")]
			[Address(RVA = "0xBA9A", Offset = "0xBA9A", VA = "0xBA9A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007056 RID: 28758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007056")]
		[Address(RVA = "0xBA9B", Offset = "0xBA9B", VA = "0xBA9B", Slot = "18")]
		public void Play(string state, bool loop)
		{
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007057")]
		[Address(RVA = "0xBA9C", Offset = "0xBA9C", VA = "0xBA9C", Slot = "20")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x06007058 RID: 28760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007058")]
		[Address(RVA = "0xBA9D", Offset = "0xBA9D", VA = "0xBA9D")]
		public GameSimpleUnityAnimation()
		{
		}

		// Token: 0x04003A91 RID: 14993
		[Token(Token = "0x4003A91")]
		[FieldOffset(Offset = "0x10")]
		public float duration;
	}
}
