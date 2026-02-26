using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache;
using Core.Cache.User;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using UnityEngine;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001146 RID: 4422
	[Token(Token = "0x2001146")]
	public class CacheManager : IGameManager, IBaseManager
	{
		// Token: 0x060067FE RID: 26622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FE")]
		[Address(RVA = "0xB32A", Offset = "0xB32A", VA = "0xB32A")]
		public CacheManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_CacheManager___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9bd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x14000268 RID: 616
		// (add) Token: 0x060067FF RID: 26623 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006800 RID: 26624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000268")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067FF")]
			[Address(RVA = "0xB32B", Offset = "0xB32B", VA = "0xB32B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006800")]
			[Address(RVA = "0xB32C", Offset = "0xB32C", VA = "0xB32C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000269 RID: 617
		// (add) Token: 0x06006801 RID: 26625 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006802 RID: 26626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000269")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006801")]
			[Address(RVA = "0xB32D", Offset = "0xB32D", VA = "0xB32D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006802")]
			[Address(RVA = "0xB32E", Offset = "0xB32E", VA = "0xB32E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06006803 RID: 26627 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006804 RID: 26628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700154D")]
		public IUserCache UsersBasic
		{
			[Token(Token = "0x6006803")]
			[Address(RVA = "0xB32F", Offset = "0xB32F", VA = "0xB32F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006804")]
			[Address(RVA = "0xB330", Offset = "0xB330", VA = "0xB330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06006805 RID: 26629 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006806 RID: 26630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700154E")]
		public ICache<ulong, UserData> Users
		{
			[Token(Token = "0x6006805")]
			[Address(RVA = "0xB331", Offset = "0xB331", VA = "0xB331")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006806")]
			[Address(RVA = "0xB332", Offset = "0xB332", VA = "0xB332")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06006807 RID: 26631 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006808 RID: 26632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700154F")]
		public ICache<ulong, ClanShortInfo> Clans
		{
			[Token(Token = "0x6006807")]
			[Address(RVA = "0xB333", Offset = "0xB333", VA = "0xB333")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006808")]
			[Address(RVA = "0xB334", Offset = "0xB334", VA = "0xB334")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06006809 RID: 26633 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600680A RID: 26634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001550")]
		public ICache<AssetDic, AudioClip> AudioClipCache
		{
			[Token(Token = "0x6006809")]
			[Address(RVA = "0xB335", Offset = "0xB335", VA = "0xB335")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600680A")]
			[Address(RVA = "0xB336", Offset = "0xB336", VA = "0xB336")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600680B")]
		[Address(RVA = "0xB337", Offset = "0xB337", VA = "0xB337")]
		public ICache<ulong, UserData> GetEndOfFrameCacheRequestAccumulator(ICache<ulong, UserData> cache)
		{
		/* --- GHIDRA: GetEndOfFrameCacheRequestAccumulator ---
		int Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator
		              (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param3;
		  int iVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a5a9c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_ArtifactCache_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a9c2 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x28);
		  if (iVar4 == 0) {
		    uVar1 = 0;
		    piVar5 = *(int **)(param1 + 8);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		          goto code_r0x812a310d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a310d:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar3 = func_ii_7112(uVar3,0);
		    piVar5 = *(int **)(param1 + 8);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		          goto code_r0x812a3198;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812a3198:
		    param3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    iVar4 = unnamed_function_1417(Core_Cache_ArtifactCache_TypeInfo);
		    Core_Cache_AbstractCache___ctor(iVar4,uVar3,param3,0);
		  }
		  *(int *)(param1 + 0x28) = iVar4;
		  return iVar4;
		}
		*/

			return null;
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x0600680C RID: 26636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001551")]
		public ArtifactCache Artifacts
		{
			[Token(Token = "0x600680C")]
			[Address(RVA = "0xB338", Offset = "0xB338", VA = "0xB338")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600680D")]
		[Address(RVA = "0xB339", Offset = "0xB339", VA = "0xB339", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_CacheManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a9c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5a9c4 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812a3364;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x812a3364:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812a33e7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x812a33e7:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(param1 + 0x1c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812a346a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x812a346a:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (*(int *)(param1 + 0x28) != 0) {
		    Core_Cache_ArtifactCache___ctor(*(int *)(param1 + 0x28),0);
		  }
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x24) = 0;
		  *(undefined4 *)(param1 + 8) = 0;
		  iVar4 = *(int *)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		            (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600680E RID: 26638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600680E")]
		[Address(RVA = "0xB33A", Offset = "0xB33A", VA = "0xB33A", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_CacheManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a9c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4536);
		    DAT_ram_00a5a9c5 = '\x01';
		  }
		  return StringLiteral_4536;
		}
		*/

		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x0600680F RID: 26639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001552")]
		public string Name
		{
			[Token(Token = "0x600680F")]
			[Address(RVA = "0xB33B", Offset = "0xB33B", VA = "0xB33B", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400376B RID: 14187
		[Token(Token = "0x400376B")]
		[FieldOffset(Offset = "0x8")]
		private IGame _game;

		// Token: 0x04003772 RID: 14194
		[Token(Token = "0x4003772")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<ICache<ulong, UserData>, EndOfFrameAccumulativeCacheDataRequest<ulong, UserData>> _currentEndOfFrameCacheDataRequests;

		// Token: 0x04003773 RID: 14195
		[Token(Token = "0x4003773")]
		[FieldOffset(Offset = "0x28")]
		private ArtifactCache _artifactCache;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_CacheManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9be = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_CacheManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9bf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_CacheManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9c0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_AudioClipCache ---
		int Core_Gameplay_Managers_CacheManager__set_AudioClipCache
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int local_4;
		  
		  if (DAT_ram_00a5a9c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Cache_EndOfFrameAccumulativeCacheDataRequest_ulong__UserData__get_FrameIndex__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Cache_EndOfFrameAccumulativeCacheDataRequest_ulong__UserData__TypeInfo);
		    DAT_ram_00a5a9c1 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = *(int *)(param1 + 0x24);
		  if (iVar1 == 0) {
		    iVar1 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (iVar1,
		               Method_System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData____ctor__
		              );
		    *(int *)(param1 + 0x24) = iVar1;
		  }
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (iVar1,param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    iVar2 = *(int *)(local_4 + 0x14);
		    iVar1 = func_ii_10467(0);
		    if (iVar2 == iVar1) {
		      return local_4;
		    }
		    System_Linq_Enumerable__First_KeyValuePair_object__object__
		              (*(undefined4 *)(param1 + 0x24),param2,
		               Method_System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___Remove__
		              );
		  }
		  iVar1 = unnamed_function_1417
		                    (Core_Cache_EndOfFrameAccumulativeCacheDataRequest_ulong__UserData__TypeInfo);
		  Sirenix_Serialization_EmptyTypeFormatter___Il2CppFullySharedGenericType___WriteDataEntries
		            (iVar1,param2,
		             Method_Core_Cache_EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___ctor__);
		  local_4 = iVar1;
		  System_Reflection_FieldInfo__get_IsStatic
		            (*(undefined4 *)(param1 + 0x24),param2,iVar1,
		             Method_System_Collections_Generic_Dictionary_ICache_ulong__UserData___EndOfFrameAccumulativeCacheDataRequest_ulong__UserData___Add__
		            );
		  return local_4;
		}
		*/


		/* --- GHIDRA: get_Artifacts ---
		void Core_Gameplay_Managers_CacheManager__get_Artifacts(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5a9c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_Audio_AudioClipCache_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_Clan_ClanCache_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCacheBasicInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_UserCache_TypeInfo);
		    DAT_ram_00a5a9c3 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Cache_User_UserCacheBasicInfo_TypeInfo);
		  Core_Cache_User_UserCache___c__DisplayClass6_1___Update_b__2(uVar1,120.0,0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  param1_00 = unnamed_function_1417(Core_Cache_User_UserCache_TypeInfo);
		  Core_Cache_User_UserCache__Dispose(param1_00,uVar1,120.0,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  uVar1 = unnamed_function_1417(Core_Cache_Clan_ClanCache_TypeInfo);
		  Core_Cache_Clan_ClanCache__Dispose(uVar1,500.0,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417(Core_Cache_Audio_AudioClipCache_TypeInfo);
		  if (DAT_ram_00a5a8d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_AssetDic__AudioClip___ctor__);
		    DAT_ram_00a5a8d7 = '\x01';
		  }
		  Gameplay_Boss_View_AbstractBossWindowView_object__object___Start
		            (uVar1,3.4028235e+38,Method_Core_Cache_AbstractCache_AssetDic__AudioClip___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  iVar2 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_CacheManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9c6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
