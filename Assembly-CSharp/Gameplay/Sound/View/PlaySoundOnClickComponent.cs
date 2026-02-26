using System;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Sound.View
{
	// Token: 0x02000C72 RID: 3186
	[Token(Token = "0x2000C72")]
	public class PlaySoundOnClickComponent : PlaySoundComponent, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06004DCF RID: 19919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCF")]
		[Address(RVA = "0x9C07", Offset = "0x9C07", VA = "0x9C07", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD0")]
		[Address(RVA = "0x9C08", Offset = "0x9C08", VA = "0x9C08")]
		public PlaySoundOnClickComponent()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Sound_View_PlaySoundOnClickComponent___ctor(int param1,undefined4 param2)
		
		{
		  Gameplay_Sound_View_GameAudioSource___ctor(param1,*(undefined4 *)(param1 + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x04002A5E RID: 10846
		[Token(Token = "0x4002A5E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Sounds _sound;
	}
}
