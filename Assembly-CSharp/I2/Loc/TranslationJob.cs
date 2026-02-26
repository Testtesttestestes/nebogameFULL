using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001360 RID: 4960
	[Token(Token = "0x2001360")]
	public class TranslationJob : IDisposable
	{
		// Token: 0x060075CA RID: 30154 RVA: 0x00015438 File Offset: 0x00013638
		[Token(Token = "0x60075CA")]
		[Address(RVA = "0xBF53", Offset = "0xBF53", VA = "0xBF53", Slot = "5")]
		public virtual TranslationJob.eJobState GetState()
		{
			return TranslationJob.eJobState.Running;
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CB")]
		[Address(RVA = "0xBF54", Offset = "0xBF54", VA = "0xBF54", Slot = "6")]
		public virtual void Dispose()
		{
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CC")]
		[Address(RVA = "0xBF55", Offset = "0xBF55", VA = "0xBF55")]
		public TranslationJob()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_TranslationJob___ctor(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0xc) != 0) {
		    UnityEngine_Networking_UnityWebRequest__Finalize(*(int *)(param1 + 0xc),0);
		  }
		  *(undefined4 *)(param1 + 0xc) = 0;
		  return;
		}
		*/

		}

		// Token: 0x04003D7C RID: 15740
		[Token(Token = "0x4003D7C")]
		[FieldOffset(Offset = "0x8")]
		public TranslationJob.eJobState mJobState;

		// Token: 0x02001361 RID: 4961
		[Token(Token = "0x2001361")]
		public enum eJobState
		{
			// Token: 0x04003D7E RID: 15742
			[Token(Token = "0x4003D7E")]
			Running,
			// Token: 0x04003D7F RID: 15743
			[Token(Token = "0x4003D7F")]
			Succeeded,
			// Token: 0x04003D80 RID: 15744
			[Token(Token = "0x4003D80")]
			Failed
		}
	}
}
