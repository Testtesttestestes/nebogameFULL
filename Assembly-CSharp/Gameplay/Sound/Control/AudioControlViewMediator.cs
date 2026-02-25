using System;
using Gameplay.Sound.Model;
using Gameplay.Sound.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Sound.Control
{
	// Token: 0x02000C77 RID: 3191
	[Token(Token = "0x2000C77")]
	public class AudioControlViewMediator : AbstractViewMediator<AudioModel, AudioEvents, AudioController, AudioControlsView>
	{
		// Token: 0x06004DE9 RID: 19945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x9C21", Offset = "0x9C21", VA = "0x9C21", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x9C22", Offset = "0x9C22", VA = "0x9C22")]
		public AudioControlViewMediator(AudioModel model, AudioEvents events, AudioController controller)
		{
		}

		// Token: 0x17000FCE RID: 4046
		// (set) Token: 0x06004DEB RID: 19947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FCE")]
		public override AudioControlsView View
		{
			[Token(Token = "0x6004DEB")]
			[Address(RVA = "0x9C23", Offset = "0x9C23", VA = "0x9C23", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x9C24", Offset = "0x9C24", VA = "0x9C24")]
		private void HandleSoundFXOnValueChangedEvent(bool value)
		{
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x9C25", Offset = "0x9C25", VA = "0x9C25")]
		private void HandleMusicOnValueChangedEvent(bool value)
		{
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x9C26", Offset = "0x9C26", VA = "0x9C26")]
		private void SetupView()
		{
		}
	}
}
