using System;
using Core.Data;
using Core.Dict;
using Cysharp.Threading.Tasks;
using Gameplay.Antiq.Control;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Antiq
{
	// Token: 0x02000D7C RID: 3452
	[Token(Token = "0x2000D7C")]
	internal class Launch : IDisposable
	{
		// Token: 0x0600548E RID: 21646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548E")]
		[Address(RVA = "0xA241", Offset = "0xA241", VA = "0xA241", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548F")]
		[Address(RVA = "0x1E5B", Offset = "0x1E5B", VA = "0x1E5B")]
		public Launch(UserData user, IDictProvider dictProvider, PopupController popupController)
		{
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005490")]
		[Address(RVA = "0xA242", Offset = "0xA242", VA = "0xA242")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x0000F438 File Offset: 0x0000D638
		[Token(Token = "0x6005491")]
		[Address(RVA = "0x1E5C", Offset = "0x1E5C", VA = "0x1E5C")]
		public UniTask Run()
		{
			return default(UniTask);
		}

		// Token: 0x04002DBA RID: 11706
		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x8")]
		public readonly AntiqController Controller;

		// Token: 0x04002DBB RID: 11707
		[Token(Token = "0x4002DBB")]
		[FieldOffset(Offset = "0xC")]
		public readonly AntiqEvents Events;

		// Token: 0x04002DBC RID: 11708
		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0x10")]
		public readonly AntiqModel Model;

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x14")]
		private UniTaskCompletionSource _tcs;

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x18")]
		private bool _isDisposed;
	}
}
