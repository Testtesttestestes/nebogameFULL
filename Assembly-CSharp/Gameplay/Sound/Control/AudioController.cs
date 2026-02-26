using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Sound.Control
{
	// Token: 0x02000C78 RID: 3192
	[Token(Token = "0x2000C78")]
	public class AudioController : AbstractController<AudioModel, AudioEvents>, IGameAudio
	{
		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06004DEF RID: 19951 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004DF0 RID: 19952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FCF")]
		private Coroutine _detectCoroutine
		{
			[Token(Token = "0x6004DEF")]
			[Address(RVA = "0x9C27", Offset = "0x9C27", VA = "0x9C27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DF0")]
			[Address(RVA = "0x9C28", Offset = "0x9C28", VA = "0x9C28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x9C29", Offset = "0x9C29", VA = "0x9C29")]
		public AudioController(AudioModel model, AudioEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Sound_Control_AudioController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF2")]
		[Address(RVA = "0x9C2A", Offset = "0x9C2A", VA = "0x9C2A", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Sound_Control_AudioController__HandleRun(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Sound_Control_AudioController__PlayMusic(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF3")]
		[Address(RVA = "0x9C2B", Offset = "0x9C2B", VA = "0x9C2B", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		int Gameplay_Sound_Control_AudioController__HandleStop
		              (undefined4 param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5982c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Sound_Control_AudioController__MusicClipFinishDetectorCoroutine_d__8_TypeInfo
		              );
		    DAT_ram_00a5982c = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Sound_Control_AudioController__MusicClipFinishDetectorCoroutine_d__8_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x18) = param2;
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param3;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x9C2C", Offset = "0x9C2C", VA = "0x9C2C")]
		private IEnumerator MusicClipFinishDetectorCoroutine(AssetDic assetDic, float length)
		{
		/* --- GHIDRA: MusicClipFinishDetectorCoroutine ---
		int Gameplay_Sound_Control_AudioController__MusicClipFinishDetectorCoroutine
		              (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param2 + 0xc);
		  do {
		    iVar1 = UnityEngine_Random__Range(0,iVar1,0);
		    iVar1 = *(int *)(param2 + iVar1 * 4 + 0x10);
		    if (iVar1 != param3) {
		      return iVar1;
		    }
		    iVar1 = *(int *)(param2 + 0xc);
		  } while (1 < iVar1);
		  return param3;
		}
		*/

			return null;
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DF5")]
		[Address(RVA = "0x9C2D", Offset = "0x9C2D", VA = "0x9C2D")]
		private AssetDic GetPlayListItem(AssetDic[] playlist, AssetDic currentItem)
		{
		/* --- GHIDRA: GetPlayListItem ---
		void Gameplay_Sound_Control_AudioController__GetPlayListItem(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int iVar3;
		  int param2_01;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a5982d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Model_PlayLists_TypeInfo);
		    DAT_ram_00a5982d = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_8 = *(undefined4 *)(iVar1 + 0x18);
		  local_c = 0xffffffff;
		  local_10 = Gameplay_Sound_Model_PlayLists_TypeInfo;
		  param2_00 = Spine_SkeletonJson__GetFloat(&local_10,0);
		  iVar2 = Gameplay_Sound_Model_AudioModel__TryGetSoundAsset(param1_00,param2_00,&local_4,param1_00);
		  iVar1 = local_4;
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = *(int *)(iVar2 + 0x1c);
		    iVar2 = *(int *)(iVar1 + 0xc);
		    do {
		      iVar2 = UnityEngine_Random__Range(0,iVar2,0);
		      param2_01 = *(int *)(iVar1 + iVar2 * 4 + 0x10);
		      if (param2_01 != iVar3) break;
		      iVar2 = *(int *)(iVar1 + 0xc);
		      param2_01 = iVar3;
		    } while (1 < iVar2);
		    Gameplay_Sound_Control_AudioController__PlayMusic(param1,param2_01,iVar1);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF6")]
		[Address(RVA = "0x9C2E", Offset = "0x9C2E", VA = "0x9C2E")]
		private void PlayMusic()
		{
		/* --- GHIDRA: PlayMusic ---
		void Gameplay_Sound_Control_AudioController__PlayMusic
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  longlong param2_00;
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  uint uVar7;
		  int param2_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59833 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_AssetDic___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_AssetDic__AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Sound_Control_AudioController___c__DisplayClass16_0__PlayMusic_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Sound_Control_AudioController___c__DisplayClass16_0_TypeInfo);
		    DAT_ram_00a59833 = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Sound_Control_AudioController___c__DisplayClass16_0_TypeInfo);
		  *(undefined4 *)(iVar3 + 0xc) = param2;
		  *(int **)(iVar3 + 8) = param1;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  piVar6 = *(int **)(iVar4 + 0xc);
		  iVar4 = *piVar6;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810772ba;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x810772ba:
		  uVar1 = CONCAT44(uVar2,puVar5[1]);
		  iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,uVar1);
		  if (*(char *)(iVar4 + 9) != '\0') {
		    param2_01 = *param1;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(param2_01 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(param2_01 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (*(int *)(iVar4 + 0x1c) != 0) {
		      Gameplay_Sound_Control_AudioController__PlayMusic(param1,param2_01);
		    }
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar4 + 0x1c) = *(undefined4 *)(iVar3 + 0xc);
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    piVar6 = *(int **)(iVar4 + 0x10);
		    uVar7 = 0;
		    param1_00 = unnamed_function_1417(Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		    Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		              (param1_00,iVar3,
		               Method_Gameplay_Sound_Control_AudioController___c__DisplayClass16_0__PlayMusic_b__0__
		               ,0);
		    iVar4 = Mono_Security_ASN1Convert__ToOid(Protocol_Dic_AssetDic___TypeInfo,1);
		    *(undefined4 *)(iVar4 + 0x10) = *(undefined4 *)(iVar3 + 0xc);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_ICache_AssetDic__AudioClip__TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 200);
		          goto code_r0x810773d7;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar6,Core_Cache_ICache_AssetDic__AudioClip__TypeInfo,1);
		code_r0x810773d7:
		    param2_00 = (**(code **)((ulonglong)*puVar5 * 4))
		                          (piVar6,CONCAT44(uVar2,param1_00),iVar4,puVar5[1]);
		    iVar3 = Method_System_Collections_Generic_List_long__Add__;
		    if (0 < param2_00) {
		      iVar4 = param1[7];
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar7 = *(uint *)(iVar4 + 0xc);
		      if (uVar7 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		        *(uint *)(iVar4 + 0xc) = uVar7 + 1;
		        *(longlong *)(*(int *)(iVar4 + 8) + uVar7 * 8 + 0x10) = param2_00;
		        return;
		      }
		      System_Collections_Generic_List_ulong___Contains
		                (iVar4,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  return;
		}
		*/

		/* --- GHIDRA: PlayMusic ---
		void Gameplay_Sound_Control_AudioController__PlayMusic
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  longlong param2_00;
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  uint uVar7;
		  int param2_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59833 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_AssetDic___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_AssetDic__AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Sound_Control_AudioController___c__DisplayClass16_0__PlayMusic_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Sound_Control_AudioController___c__DisplayClass16_0_TypeInfo);
		    DAT_ram_00a59833 = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Sound_Control_AudioController___c__DisplayClass16_0_TypeInfo);
		  *(undefined4 *)(iVar3 + 0xc) = param2;
		  *(int **)(iVar3 + 8) = param1;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  piVar6 = *(int **)(iVar4 + 0xc);
		  iVar4 = *piVar6;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810772ba;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x810772ba:
		  uVar1 = CONCAT44(uVar2,puVar5[1]);
		  iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,uVar1);
		  if (*(char *)(iVar4 + 9) != '\0') {
		    param2_01 = *param1;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(param2_01 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(param2_01 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (*(int *)(iVar4 + 0x1c) != 0) {
		      Gameplay_Sound_Control_AudioController__PlayMusic(param1,param2_01);
		    }
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar4 + 0x1c) = *(undefined4 *)(iVar3 + 0xc);
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    piVar6 = *(int **)(iVar4 + 0x10);
		    uVar7 = 0;
		    param1_00 = unnamed_function_1417(Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		    Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		              (param1_00,iVar3,
		               Method_Gameplay_Sound_Control_AudioController___c__DisplayClass16_0__PlayMusic_b__0__
		               ,0);
		    iVar4 = Mono_Security_ASN1Convert__ToOid(Protocol_Dic_AssetDic___TypeInfo,1);
		    *(undefined4 *)(iVar4 + 0x10) = *(undefined4 *)(iVar3 + 0xc);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_ICache_AssetDic__AudioClip__TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 200);
		          goto code_r0x810773d7;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar6,Core_Cache_ICache_AssetDic__AudioClip__TypeInfo,1);
		code_r0x810773d7:
		    param2_00 = (**(code **)((ulonglong)*puVar5 * 4))
		                          (piVar6,CONCAT44(uVar2,param1_00),iVar4,puVar5[1]);
		    iVar3 = Method_System_Collections_Generic_List_long__Add__;
		    if (0 < param2_00) {
		      iVar4 = param1[7];
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar7 = *(uint *)(iVar4 + 0xc);
		      if (uVar7 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		        *(uint *)(iVar4 + 0xc) = uVar7 + 1;
		        *(longlong *)(*(int *)(iVar4 + 8) + uVar7 * 8 + 0x10) = param2_00;
		        return;
		      }
		      System_Collections_Generic_List_ulong___Contains
		                (iVar4,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  return;
		}
		*/

		/* --- GHIDRA: PlayMusic ---
		void Gameplay_Sound_Control_AudioController__PlayMusic
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  longlong param2_00;
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  uint uVar7;
		  int param2_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59833 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_AssetDic___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_AssetDic__AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Sound_Control_AudioController___c__DisplayClass16_0__PlayMusic_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Sound_Control_AudioController___c__DisplayClass16_0_TypeInfo);
		    DAT_ram_00a59833 = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Sound_Control_AudioController___c__DisplayClass16_0_TypeInfo);
		  *(undefined4 *)(iVar3 + 0xc) = param2;
		  *(int **)(iVar3 + 8) = param1;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  piVar6 = *(int **)(iVar4 + 0xc);
		  iVar4 = *piVar6;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810772ba;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x810772ba:
		  uVar1 = CONCAT44(uVar2,puVar5[1]);
		  iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,uVar1);
		  if (*(char *)(iVar4 + 9) != '\0') {
		    param2_01 = *param1;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(param2_01 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(param2_01 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (*(int *)(iVar4 + 0x1c) != 0) {
		      Gameplay_Sound_Control_AudioController__PlayMusic(param1,param2_01);
		    }
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar4 + 0x1c) = *(undefined4 *)(iVar3 + 0xc);
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    piVar6 = *(int **)(iVar4 + 0x10);
		    uVar7 = 0;
		    param1_00 = unnamed_function_1417(Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		    Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		              (param1_00,iVar3,
		               Method_Gameplay_Sound_Control_AudioController___c__DisplayClass16_0__PlayMusic_b__0__
		               ,0);
		    iVar4 = Mono_Security_ASN1Convert__ToOid(Protocol_Dic_AssetDic___TypeInfo,1);
		    *(undefined4 *)(iVar4 + 0x10) = *(undefined4 *)(iVar3 + 0xc);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_ICache_AssetDic__AudioClip__TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 200);
		          goto code_r0x810773d7;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar6,Core_Cache_ICache_AssetDic__AudioClip__TypeInfo,1);
		code_r0x810773d7:
		    param2_00 = (**(code **)((ulonglong)*puVar5 * 4))
		                          (piVar6,CONCAT44(uVar2,param1_00),iVar4,puVar5[1]);
		    iVar3 = Method_System_Collections_Generic_List_long__Add__;
		    if (0 < param2_00) {
		      iVar4 = param1[7];
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar7 = *(uint *)(iVar4 + 0xc);
		      if (uVar7 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		        *(uint *)(iVar4 + 0xc) = uVar7 + 1;
		        *(longlong *)(*(int *)(iVar4 + 8) + uVar7 * 8 + 0x10) = param2_00;
		        return;
		      }
		      System_Collections_Generic_List_ulong___Contains
		                (iVar4,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x9C2F", Offset = "0x9C2F", VA = "0x9C2F")]
		public void SetSoundFXEnabled(bool value)
		{
		/* --- GHIDRA: SetSoundFXEnabled ---
		void Gameplay_Sound_Control_AudioController__SetSoundFXEnabled
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5982f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a5982f = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(iVar2 + 0xc);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81076bb5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x81076bb5:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(char *)(iVar2 + 9) = (char)param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar2 + 0xc);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x81076c55;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Data_User_IUserSettings_TypeInfo,1);
		code_r0x81076c55:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  if (param2 != 0) {
		    Gameplay_Sound_Control_AudioController__GetPlayListItem(param1,puVar3);
		    return;
		  }
		  Gameplay_Sound_Control_AudioController__PlayMusic(param1,puVar3);
		  return;
		}
		*/

		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x9C30", Offset = "0x9C30", VA = "0x9C30")]
		public void SetMusicEnabled(bool value)
		{
		/* --- GHIDRA: SetMusicEnabled ---
		void Gameplay_Sound_Control_AudioController__SetMusicEnabled
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a59831 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_AssetDic___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Sound_Control_AudioController__PlaySound_b__14_0__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_AssetDic__AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a59831 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar3 = *(int **)(iVar1 + 0xc);
		  iVar1 = *piVar3;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8)) {
		        puVar2 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107620b;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar5);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8107620b:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (*(char *)(iVar1 + 8) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar3 = *(int **)(iVar1 + 0x10);
		    uVar5 = 0;
		    param1_00 = unnamed_function_1417(Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		    Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		              (param1_00,param1,Method_Gameplay_Sound_Control_AudioController__PlaySound_b__14_0__,0
		              );
		    iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Dic_AssetDic___TypeInfo,1);
		    *(undefined4 *)(iVar1 + 0x10) = param2;
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_ICache_AssetDic__AudioClip__TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 200);
		          goto code_r0x810762e0;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Cache_ICache_AssetDic__AudioClip__TypeInfo,1);
		code_r0x810762e0:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1_00,iVar1,puVar2[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x38E4", Offset = "0x38E4", VA = "0x38E4", Slot = "13")]
		public void PlaySound(Sounds sound)
		{
		/* --- GHIDRA: PlaySound ---
		int * Gameplay_Sound_Control_AudioController__PlaySound(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: PlaySound ---
		int * Gameplay_Sound_Control_AudioController__PlaySound(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x9C31", Offset = "0x9C31", VA = "0x9C31", Slot = "14")]
		public void PlaySound(AssetDic asset)
		{
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x9C32", Offset = "0x9C32", VA = "0x9C32", Slot = "12")]
		public void PlayMusic(PlayLists playlistName)
		{
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x9C33", Offset = "0x9C33", VA = "0x9C33")]
		public void PlayMusic(AssetDic asset)
		{
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFD")]
		[Address(RVA = "0x9C34", Offset = "0x9C34", VA = "0x9C34", Slot = "15")]
		public void StopMusic()
		{
		/* --- GHIDRA: StopMusic ---
		void Gameplay_Sound_Control_AudioController__StopMusic
		               (int *param1,undefined8 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param3 + 0x10),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x04002A8E RID: 10894
		[Token(Token = "0x4002A8E")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<long> _musicAudioCacheOperationsIndexes;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set__detectCoroutine ---
		void Gameplay_Sound_Control_AudioController__set__detectCoroutine
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5982b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_AudioModel__AudioEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_long__TypeInfo);
		    DAT_ram_00a5982b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_long__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_long___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_AudioModel__AudioEvents___ctor__);
		  return;
		}
		*/

}
