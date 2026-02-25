using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000983 RID: 2435
	[Token(Token = "0x2000983")]
	public class EmptyCombatAnimation : ICombatAnimation, IDisposable
	{
		// Token: 0x06003A17 RID: 14871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A17")]
		[Address(RVA = "0x899B", Offset = "0x899B", VA = "0x899B", Slot = "7")]
		public void Append(string path, bool isLeft)
		{
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A18")]
		[Address(RVA = "0x899C", Offset = "0x899C", VA = "0x899C", Slot = "8")]
		public void Append(CombatAnimation.IContent content)
		{
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A19")]
		[Address(RVA = "0x899D", Offset = "0x899D", VA = "0x899D", Slot = "9")]
		public void CancelLoad()
		{
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1A")]
		[Address(RVA = "0x899E", Offset = "0x899E", VA = "0x899E", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x1400018C RID: 396
		// (add) Token: 0x06003A1B RID: 14875 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A1C RID: 14876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400018C")]
		public event Action<CombatAnimation.IContent> OnAnimExecuteEvent
		{
			[Token(Token = "0x6003A1B")]
			[Address(RVA = "0x899F", Offset = "0x899F", VA = "0x899F", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A1C")]
			[Address(RVA = "0x89A0", Offset = "0x89A0", VA = "0x89A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A1D")]
		[Address(RVA = "0x89A1", Offset = "0x89A1", VA = "0x89A1", Slot = "6")]
		public OpToken<CombatAnimation.IContent, CombatAnimation.IContent> Load(string path)
		{
			return null;
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1E")]
		[Address(RVA = "0x89A2", Offset = "0x89A2", VA = "0x89A2", Slot = "11")]
		public void Reset()
		{
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1F")]
		[Address(RVA = "0x89A3", Offset = "0x89A3", VA = "0x89A3", Slot = "10")]
		public void Stop()
		{
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A20")]
		[Address(RVA = "0x89A4", Offset = "0x89A4", VA = "0x89A4")]
		public EmptyCombatAnimation()
		{
		}
	}
}
