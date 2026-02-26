using System;
using System.Collections;
using AssetContent.Loaders;
using Core.Animations;
using Core.Dict.DictWrappers.Wrappers;
using Core.Materials;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.User.View.Monster
{
	// Token: 0x02000D25 RID: 3365
	[Token(Token = "0x2000D25")]
	public class MonsterOnIsleAvatarAnimation : MonoBehaviour, IAlpha
	{
		// Token: 0x06005245 RID: 21061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005245")]
		[Address(RVA = "0xA01C", Offset = "0xA01C", VA = "0xA01C")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__OnEnable
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int param2_01;
		  
		  param2_01 = 0;
		  Core_Animations_GameSpineAnimation__get_SortingOrder(*(undefined4 *)(param1 + 0x14),2,0);
		  *(int *)(param1 + 0x24) = *(int *)(param1 + 0x24) + 1;
		  iVar1 = Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__Validate(param1,0);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param1_00 = *(undefined4 *)(iVar1 + param2_01 * 4 + 0x10);
		      param2_00 = UnityEngine_Renderer__set_sortingLayerName(*(undefined4 *)(param1 + 0x10),0);
		      Core_Animations_GameSpineAnimation__get_SortingLayerId(param1_00,param2_00,0);
		      param2_01 = param2_01 + 1;
		    } while (param2_01 < *(int *)(iVar1 + 0xc));
		  }
		  Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__Start(param1,param2_01);
		  return;
		}
		*/

		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005246")]
		[Address(RVA = "0xA01D", Offset = "0xA01D", VA = "0xA01D")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__Start
		               (int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x20);
		  if (iVar2 != 0) {
		    if (*(int *)(param1 + 0x2c) != 0) {
		      func_ii_20511(param1,*(int *)(param1 + 0x2c),0);
		    }
		    if (DAT_ram_00a58d7d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarRoutine_d__19_TypeInfo
		                );
		      DAT_ram_00a58d7d = '\x01';
		    }
		    param2_00 = unnamed_function_1417
		                          (
		                          Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarRoutine_d__19_TypeInfo
		                          );
		    *(int *)(param2_00 + 0x14) = iVar2;
		    *(int *)(param2_00 + 0x10) = param1;
		    *(undefined4 *)(param2_00 + 8) = 0;
		    uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		    *(undefined4 *)(param1 + 0x2c) = uVar1;
		    return;
		  }
		  Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__HideAvatarImage(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005247")]
		[Address(RVA = "0xA01E", Offset = "0xA01E", VA = "0xA01E")]
		private void Validate()
		{
		/* --- GHIDRA: Validate ---
		int * Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__Validate
		                (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58d7a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimation___TypeInfo);
		    DAT_ram_00a58d7a = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x28);
		  if (piVar3 == (int *)0x0) {
		    piVar3 = (int *)Mono_Security_ASN1Convert__ToOid
		                              (Core_Animations_GameSpineAnimation___TypeInfo,2);
		    iVar4 = *(int *)(param1 + 0x14);
		    if ((iVar4 != 0) && (iVar1 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20)), iVar1 == 0)) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar3[4] = iVar4;
		    iVar4 = *(int *)(param1 + 0x18);
		    if ((iVar4 != 0) && (iVar1 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20)), iVar1 == 0)) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar3[5] = iVar4;
		    *(int **)(param1 + 0x28) = piVar3;
		  }
		  return piVar3;
		}
		*/

		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010BE")]
		public GameSpineAnimation[] Animations
		{
			[Token(Token = "0x6005248")]
			[Address(RVA = "0xA01F", Offset = "0xA01F", VA = "0xA01F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005249")]
		[Address(RVA = "0xA020", Offset = "0xA020", VA = "0xA020")]
		private IEnumerator ShowAvatarImage(AprDicWrapper data)
		{
		/* --- GHIDRA: ShowAvatarImage ---
		void Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarImage
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524A")]
		[Address(RVA = "0xA021", Offset = "0xA021", VA = "0xA021")]
		private void HideAvatarImage()
		{
		/* --- GHIDRA: HideAvatarImage ---
		void Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__HideAvatarImage
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d7c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation_PortalAnimationStates_TypeInfo
		              );
		    DAT_ram_00a58d7c = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  local_8 = 0x1ffffffff;
		  local_c = 
		  Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation_PortalAnimationStates_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  Core_Animations_GameSpineAnimation__set_Loop(param1_00,uVar1,1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524B")]
		[Address(RVA = "0xA022", Offset = "0xA022", VA = "0xA022")]
		private void ShowAwait()
		{
		/* --- GHIDRA: ShowAwait ---
		void Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAwait
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (*(int *)(param1 + 0x2c) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x2c),0);
		  }
		  if (DAT_ram_00a58d7d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarRoutine_d__19_TypeInfo
		              );
		    DAT_ram_00a58d7d = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarRoutine_d__19_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x14) = param2;
		  *(int *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600524C RID: 21068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524C")]
		[Address(RVA = "0xA023", Offset = "0xA023", VA = "0xA023")]
		private void ShowAvatar(AprDicWrapper data)
		{
		/* --- GHIDRA: ShowAvatar ---
		int Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatar
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58d7d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarRoutine_d__19_TypeInfo
		              );
		    DAT_ram_00a58d7d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarRoutine_d__19_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600524D RID: 21069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600524D")]
		[Address(RVA = "0xA024", Offset = "0xA024", VA = "0xA024")]
		private IEnumerator ShowAvatarRoutine(AprDicWrapper data)
		{
		/* --- GHIDRA: ShowAvatarRoutine ---
		int Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarRoutine
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58d7e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__AnimateShowAvatar_d__20_TypeInfo
		              );
		    DAT_ram_00a58d7e = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__AnimateShowAvatar_d__20_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600524E")]
		[Address(RVA = "0xA025", Offset = "0xA025", VA = "0xA025")]
		private IEnumerator AnimateShowAvatar()
		{
		/* --- GHIDRA: AnimateShowAvatar ---
		void Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__AnimateShowAvatar
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (*(int *)(param1 + 0x20) == 0) {
		    Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__HideAvatarImage(param1,param1);
		    return;
		  }
		  iVar1 = func_ii_12174(param1,0);
		  if (iVar1 != 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x20);
		    if (*(int *)(param1 + 0x2c) != 0) {
		      func_ii_20511(param1,*(int *)(param1 + 0x2c),0);
		    }
		    if (DAT_ram_00a58d7d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarRoutine_d__19_TypeInfo
		                );
		      DAT_ram_00a58d7d = '\x01';
		    }
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarRoutine_d__19_TypeInfo
		                      );
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    *(int *)(iVar1 + 0x10) = param1;
		    *(undefined4 *)(iVar1 + 8) = 0;
		    uVar2 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar1,0);
		    *(undefined4 *)(param1 + 0x2c) = uVar2;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524F")]
		[Address(RVA = "0xA026", Offset = "0xA026", VA = "0xA026")]
		private void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__HandleDataChanged
		               (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__Validate(param1,param1);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      Core_Animations_GameSpineAnimation__SetGrayscale
		                (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),param2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005250")]
		[Address(RVA = "0xA027", Offset = "0xA027", VA = "0xA027", Slot = "4")]
		public void SetAlpha(float value)
		{
		/* --- GHIDRA: SetAlpha ---
		void Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__SetAlpha
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x20)) {
		    *(int *)(param1 + 0x20) = param2;
		    Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__AnimateShowAvatar(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005251")]
		[Address(RVA = "0xA028", Offset = "0xA028", VA = "0xA028")]
		public void SetApr(AprDicWrapper value)
		{
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005252")]
		[Address(RVA = "0xA029", Offset = "0xA029", VA = "0xA029")]
		public MonsterOnIsleAvatarAnimation()
		{
		}

		// Token: 0x04002CC1 RID: 11457
		[Token(Token = "0x4002CC1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SpriteRenderer _cloudPlatform;

		// Token: 0x04002CC2 RID: 11458
		[Token(Token = "0x4002CC2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameSpineAnimation _avatarTopLayerAnimation;

		// Token: 0x04002CC3 RID: 11459
		[Token(Token = "0x4002CC3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameSpineAnimation _animation;

		// Token: 0x04002CC4 RID: 11460
		[Token(Token = "0x4002CC4")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameSpriteRendererLoader _avatar;

		// Token: 0x04002CC5 RID: 11461
		[Token(Token = "0x4002CC5")]
		[FieldOffset(Offset = "0x20")]
		private AprDicWrapper _aprData;

		// Token: 0x04002CC6 RID: 11462
		[Token(Token = "0x4002CC6")]
		[FieldOffset(Offset = "0x24")]
		private int _startCallCount;

		// Token: 0x04002CC7 RID: 11463
		[Token(Token = "0x4002CC7")]
		[FieldOffset(Offset = "0x28")]
		private GameSpineAnimation[] _animations;

		// Token: 0x04002CC8 RID: 11464
		[Token(Token = "0x4002CC8")]
		[FieldOffset(Offset = "0x2C")]
		private Coroutine _showAvatarCoroutine;

		// Token: 0x02000D26 RID: 3366
		[Token(Token = "0x2000D26")]
		public enum PortalAnimationStates
		{
			// Token: 0x04002CCA RID: 11466
			[Token(Token = "0x4002CCA")]
			unknown,
			// Token: 0x04002CCB RID: 11467
			[Token(Token = "0x4002CCB")]
			idle,
			// Token: 0x04002CCC RID: 11468
			[Token(Token = "0x4002CCC")]
			splash,
			// Token: 0x04002CCD RID: 11469
			[Token(Token = "0x4002CCD")]
			splash_portal_release,
			// Token: 0x04002CCE RID: 11470
			[Token(Token = "0x4002CCE")]
			splash_portal_idle
		}

		// Token: 0x02000D27 RID: 3367
		[Token(Token = "0x2000D27")]
		public enum ToplayerPortalAnimationStates
		{
			// Token: 0x04002CD0 RID: 11472
			[Token(Token = "0x4002CD0")]
			unknown,
			// Token: 0x04002CD1 RID: 11473
			[Token(Token = "0x4002CD1")]
			top_portal_idle,
			// Token: 0x04002CD2 RID: 11474
			[Token(Token = "0x4002CD2")]
			top_portal_release
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Animations ---
		int Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__get_Animations
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58d7b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarImage_d__14_TypeInfo
		              );
		    DAT_ram_00a58d7b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__ShowAvatarImage_d__14_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

}
