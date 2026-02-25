using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200112F RID: 4399
	[Token(Token = "0x200112F")]
	public class DictNameSource : IDictNameSource
	{
		// Token: 0x1400024B RID: 587
		// (add) Token: 0x06006718 RID: 26392 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006719 RID: 26393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400024B")]
		public event Action<IDictNameSource> ChangedEvent
		{
			[Token(Token = "0x6006718")]
			[Address(RVA = "0xB250", Offset = "0xB250", VA = "0xB250", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006719")]
			[Address(RVA = "0xB251", Offset = "0xB251", VA = "0xB251", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600671A")]
		[Address(RVA = "0xB252", Offset = "0xB252", VA = "0xB252")]
		public DictNameSource(string name)
		{
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600671B")]
		[Address(RVA = "0xB253", Offset = "0xB253", VA = "0xB253", Slot = "6")]
		public string GetValue()
		{
			return null;
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600671C")]
		[Address(RVA = "0xB254", Offset = "0xB254", VA = "0xB254")]
		public void SetValue(string value)
		{
		}

		// Token: 0x04003706 RID: 14086
		[Token(Token = "0x4003706")]
		[FieldOffset(Offset = "0xC")]
		private string _value;
	}
}
