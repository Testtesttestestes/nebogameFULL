using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Sound.View
{
	// Token: 0x02000C70 RID: 3184
	[Token(Token = "0x2000C70")]
	public class GameAudioSource : MonoBehaviour
	{
		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06004DCA RID: 19914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FC3")]
		public AudioSource MusicSource
		{
			[Token(Token = "0x6004DCA")]
			[Address(RVA = "0x9C02", Offset = "0x9C02", VA = "0x9C02")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06004DCB RID: 19915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FC4")]
		public AudioSource SoundSource
		{
			[Token(Token = "0x6004DCB")]
			[Address(RVA = "0x9C03", Offset = "0x9C03", VA = "0x9C03")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x9C04", Offset = "0x9C04", VA = "0x9C04")]
		public GameAudioSource()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Sound_View_GameAudioSource___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59823 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59823 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar3 != (int *)0x0) {
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x220);
		          goto code_r0x81075fb8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x81075fb8:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if ((iVar4 != 0) && (piVar3 = *(int **)(iVar4 + 0x18), piVar3 != (int *)0x0)) {
		      if (DAT_ram_00a59830 == '\0') {
		        Mono_Security_ASN1__get_Item(&Gameplay_Sound_Model_Sounds_TypeInfo);
		        DAT_ram_00a59830 = '\x01';
		      }
		      local_4 = 0;
		      param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                            (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		      local_c = 0xffffffff;
		      local_10 = Gameplay_Sound_Model_Sounds_TypeInfo;
		      local_8 = param2;
		      param2_00 = Spine_SkeletonJson__GetFloat(&local_10,0);
		      iVar4 = Gameplay_Sound_Model_AudioModel___ctor(param1_00,param2_00,&local_4,piVar3);
		      if (iVar4 != 0) {
		        Gameplay_Sound_Control_AudioController__SetMusicEnabled(piVar3,local_4,piVar3);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x04002A5C RID: 10844
		[Token(Token = "0x4002A5C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AudioSource _musicSource;

		// Token: 0x04002A5D RID: 10845
		[Token(Token = "0x4002A5D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AudioSource _soundSource;
	}
}
