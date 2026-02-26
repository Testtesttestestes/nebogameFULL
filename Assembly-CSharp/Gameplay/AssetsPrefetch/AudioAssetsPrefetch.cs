using System;
using System.Runtime.CompilerServices;
using Core.Cache;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CBB RID: 3259
	[Token(Token = "0x2000CBB")]
	public class AudioAssetsPrefetch : IDisposable
	{
		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06004F76 RID: 20342 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F77 RID: 20343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001021")]
		public ICache<AssetDic, AudioClip> AudioCache
		{
			[Token(Token = "0x6004F76")]
			[Address(RVA = "0x9D94", Offset = "0x9D94", VA = "0x9D94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F77")]
			[Address(RVA = "0x9D95", Offset = "0x9D95", VA = "0x9D95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06004F78 RID: 20344 RVA: 0x0000E988 File Offset: 0x0000CB88
		// (set) Token: 0x06004F79 RID: 20345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001022")]
		public bool IsDisposed
		{
			[Token(Token = "0x6004F78")]
			[Address(RVA = "0x9D96", Offset = "0x9D96", VA = "0x9D96")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F79")]
			[Address(RVA = "0x9D97", Offset = "0x9D97", VA = "0x9D97")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7A")]
		[Address(RVA = "0x9D98", Offset = "0x9D98", VA = "0x9D98")]
		public AudioAssetsPrefetch(ICache<AssetDic, AudioClip> audioCache, AssetDic[] assets)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AssetsPrefetch_AudioAssetsPrefetch___ctor
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a589c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		    DAT_ram_00a589c6 = '\x01';
		  }
		  if (*(char *)(param2 + 0x14) != '\0') {
		    uVar2 = unnamed_function_2232(&System_ObjectDisposedException_TypeInfo);
		    uVar2 = unnamed_function_1417(uVar2);
		    uVar1 = unnamed_function_2232(&StringLiteral_3433);
		    func_ii_11454(uVar2,uVar1,0);
		    uVar1 = unnamed_function_2232(&Method_Gameplay_AssetsPrefetch_AudioAssetsPrefetch_Fetch__);
		    func_ii_1050(uVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		  *(undefined4 *)(param2 + 0xc) = uVar2;
		  Gameplay_AssetsPrefetch_AudioAssetsPrefetch__Fetch
		            (param2,*(undefined4 *)(param2 + 0x10),uVar2,param2);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult
		            (&local_8,*(undefined4 *)(param2 + 0xc),0);
		  *param1 = local_8;
		  return;
		}
		*/

		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		[Token(Token = "0x6004F7B")]
		[Address(RVA = "0x9D99", Offset = "0x9D99", VA = "0x9D99")]
		public UniTask Fetch()
		{
		/* --- GHIDRA: Fetch ---
		void Gameplay_AssetsPrefetch_AudioAssetsPrefetch__Fetch
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int *param1_01;
		  
		  if (DAT_ram_00a589c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_AssetDic__AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AssetsPrefetch_AudioAssetsPrefetch___c__DisplayClass12_0__Warm_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AssetsPrefetch_AudioAssetsPrefetch___c__DisplayClass12_0_TypeInfo);
		    DAT_ram_00a589c7 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_AssetsPrefetch_AudioAssetsPrefetch___c__DisplayClass12_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = param3;
		  param1_01 = *(int **)(param1 + 8);
		  param1_00 = unnamed_function_1417(Core_Cache_CacheResultCallback_AudioClip__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (param1_00,iVar2,
		             Method_Gameplay_AssetsPrefetch_AudioAssetsPrefetch___c__DisplayClass12_0__Warm_b__0__,0
		            );
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Cache_ICache_AssetDic__AudioClip__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x80f57c7f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Cache_ICache_AssetDic__AudioClip__TypeInfo,1);
		code_r0x80f57c7f:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1_00,param2,puVar3[1]);
		  return;
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7C")]
		[Address(RVA = "0x9D9A", Offset = "0x9D9A", VA = "0x9D9A")]
		private void Warm(AssetDic[] assets, UniTaskCompletionSource completionSource)
		{
		/* --- GHIDRA: Warm ---
		void Gameplay_AssetsPrefetch_AudioAssetsPrefetch__Warm(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a589c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a589c8 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f57d23;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x80f57d23:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (*(int *)(param1 + 0xc) != 0) {
		    Cysharp_Threading_Tasks_UniTaskCompletionSource__MarkHandled(*(int *)(param1 + 0xc),0,0);
		  }
		  *(undefined1 *)(param1 + 0x14) = 1;
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7D")]
		[Address(RVA = "0x9D9B", Offset = "0x9D9B", VA = "0x9D9B", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04002B3E RID: 11070
		[Token(Token = "0x4002B3E")]
		[FieldOffset(Offset = "0xC")]
		private UniTaskCompletionSource _fetchCompletionSource;

		// Token: 0x04002B3F RID: 11071
		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x10")]
		private AssetDic[] _assets;
	}
}
