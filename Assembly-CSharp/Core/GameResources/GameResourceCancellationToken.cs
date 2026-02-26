using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace Core.GameResources
{
	// Token: 0x02000ECB RID: 3787
	[Token(Token = "0x2000ECB")]
	public class GameResourceCancellationToken : IDisposable
	{
		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06005C3A RID: 23610 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005C3B RID: 23611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012B7")]
		public CancellationTokenSource CancellationToken
		{
			[Token(Token = "0x6005C3A")]
			[Address(RVA = "0xA8DE", Offset = "0xA8DE", VA = "0xA8DE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C3B")]
			[Address(RVA = "0xA8DF", Offset = "0xA8DF", VA = "0xA8DF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400022D RID: 557
		// (add) Token: 0x06005C3C RID: 23612 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005C3D RID: 23613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400022D")]
		private event Action LoadCompleteEvent
		{
			[Token(Token = "0x6005C3C")]
			[Address(RVA = "0xA8E0", Offset = "0xA8E0", VA = "0xA8E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005C3D")]
			[Address(RVA = "0xA8E1", Offset = "0xA8E1", VA = "0xA8E1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06005C3E RID: 23614 RVA: 0x00010908 File Offset: 0x0000EB08
		// (set) Token: 0x06005C3F RID: 23615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012B8")]
		public bool LoadComplete
		{
			[Token(Token = "0x6005C3E")]
			[Address(RVA = "0xA8E2", Offset = "0xA8E2", VA = "0xA8E2")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C3F")]
			[Address(RVA = "0xA8E3", Offset = "0xA8E3", VA = "0xA8E3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06005C40 RID: 23616 RVA: 0x00010920 File Offset: 0x0000EB20
		[Token(Token = "0x170012B9")]
		public bool CancellationRequested
		{
			[Token(Token = "0x6005C40")]
			[Address(RVA = "0x22A5", Offset = "0x22A5", VA = "0x22A5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C41")]
		[Address(RVA = "0xA8E4", Offset = "0xA8E4", VA = "0xA8E4")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_GameResources_GameResourceCancellationToken__Init(int param1,int param2,undefined4 param3)
		
		{
		  if (*(char *)(param1 + 0x10) == '\0') {
		    *(int *)(param1 + 0xc) = param2;
		    return;
		  }
		  (**(code **)((ulonglong)*(uint *)(param2 + 0xc) * 4))
		            (*(undefined4 *)(param2 + 0x20),*(undefined4 *)(param2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C42")]
		[Address(RVA = "0xA8E5", Offset = "0xA8E5", VA = "0xA8E5")]
		public void CallWhenComplete(Action callback)
		{
		/* --- GHIDRA: CallWhenComplete ---
		void Core_GameResources_GameResourceCancellationToken__CallWhenComplete
		               (int param1,undefined4 param2)
		
		{
		  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		            (*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x22A6", Offset = "0x22A6", VA = "0x22A6")]
		public void SetLoadComplete()
		{
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C44")]
		[Address(RVA = "0xA8E6", Offset = "0xA8E6", VA = "0xA8E6")]
		public void Cancel()
		{
		/* --- GHIDRA: Cancel ---
		void Core_GameResources_GameResourceCancellationToken__Cancel(int param1,undefined4 param2)
		
		{
		  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		            (*(undefined4 *)(param1 + 8),0);
		  System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C45")]
		[Address(RVA = "0xA8E7", Offset = "0xA8E7", VA = "0xA8E7", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_GameResources_GameResourceCancellationToken__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6064a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    DAT_ram_00a6064a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(param1_00,0);
		  *(undefined1 *)(param1 + 0x10) = 1;
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C46")]
		[Address(RVA = "0xA8E8", Offset = "0xA8E8", VA = "0xA8E8")]
		public GameResourceCancellationToken()
		{
		/* --- GHIDRA: .ctor ---
		void Core_GameResources_GameResourceCancellationToken___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6064b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameResources_AudioFabric_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameAnimationsFabric_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameSpriteAtlasFabric_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameSpritesFabric_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameTextMeshProSpriteAssetFabric_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameTexturesFabric_TypeInfo);
		    DAT_ram_00a6064b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_GameResources_GameTexturesFabric_TypeInfo);
		  if (DAT_ram_00a60661 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameTextureLoader__GameResourcesManager_TextureReadyDelegate___ctor__
		              );
		    DAT_ram_00a60661 = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (uVar1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameTextureLoader__GameResourcesManager_TextureReadyDelegate___ctor__
		            );
		  **(undefined4 **)(Core_GameResources_GameResourcesManager_TypeInfo + 0x5c) = uVar1;
		  uVar1 = unnamed_function_1417(Core_GameResources_GameAnimationsFabric_TypeInfo);
		  if (DAT_ram_00a60660 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameAnimationLoader__GameResourcesManager_AnimationReadyDelegate___ctor__
		              );
		    DAT_ram_00a60660 = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (uVar1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameAnimationLoader__GameResourcesManager_AnimationReadyDelegate___ctor__
		            );
		  *(undefined4 *)(*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x5c) + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(Core_GameResources_GameSpritesFabric_TypeInfo);
		  if (DAT_ram_00a6065d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameSpriteLoader__GameResourcesManager_SpriteReadyDelegate___ctor__
		              );
		    DAT_ram_00a6065d = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (uVar1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameSpriteLoader__GameResourcesManager_SpriteReadyDelegate___ctor__
		            );
		  *(undefined4 *)(*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x5c) + 4) = uVar1;
		  uVar1 = unnamed_function_1417(Core_GameResources_GameSpriteAtlasFabric_TypeInfo);
		  if (DAT_ram_00a6065e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameSpriteAtlasLoader__GameResourcesManager_SpriteAtlasReadyDelegate___ctor__
		              );
		    DAT_ram_00a6065e = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (uVar1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameSpriteAtlasLoader__GameResourcesManager_SpriteAtlasReadyDelegate___ctor__
		            );
		  *(undefined4 *)(*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x5c) + 8) = uVar1;
		  uVar1 = unnamed_function_1417(Core_GameResources_AudioFabric_TypeInfo);
		  if (DAT_ram_00a60662 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameAudioClipLoader__GameResourcesManager_AudioClipReadyDelegate___ctor__
		              );
		    DAT_ram_00a60662 = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (uVar1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameAudioClipLoader__GameResourcesManager_AudioClipReadyDelegate___ctor__
		            );
		  *(undefined4 *)(*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x5c) + 0x14) = uVar1;
		  uVar1 = unnamed_function_1417(Core_GameResources_GameTextMeshProSpriteAssetFabric_TypeInfo);
		  if (DAT_ram_00a6065f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameTextMeshProSpriteAssetLoader__GameResourcesManager_TextMeshProSpriteAssetReadyDelegate___ctor__
		              );
		    DAT_ram_00a6065f = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (uVar1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameTextMeshProSpriteAssetLoader__GameResourcesManager_TextMeshProSpriteAssetReadyDelegate___ctor__
		            );
		  *(undefined4 *)(*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x5c) + 0xc) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CancellationToken ---
		void Core_GameResources_GameResourceCancellationToken__set_CancellationToken
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60648 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60648 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_LoadCompleteEvent ---
		void Core_GameResources_GameResourceCancellationToken__add_LoadCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60649 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60649 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_CancellationRequested ---
		void Core_GameResources_GameResourceCancellationToken__get_CancellationRequested
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined1 *)(param1 + 0x10) = 1;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  *(undefined4 *)(param1 + 0xc) = 0;
		  return;
		}
		*/

}
