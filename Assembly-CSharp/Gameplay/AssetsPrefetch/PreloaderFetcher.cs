using System;
using Core;
using Core.Dict;
using Core.GameTime;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CC1 RID: 3265
	[Token(Token = "0x2000CC1")]
	internal class PreloaderFetcher : IDisposable
	{
		// Token: 0x06004F8E RID: 20366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F8E")]
		[Address(RVA = "0x9DAB", Offset = "0x9DAB", VA = "0x9DAB", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AssetsPrefetch_PreloaderFetcher__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a589cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AssetsPrefetch_AssetsPrefetch_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3179);
		    DAT_ram_00a589cf = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  uVar1 = unnamed_function_1417(Gameplay_AssetsPrefetch_AssetsPrefetch_TypeInfo);
		  Gameplay_AssetsPrefetch_AssetsPrefetch__Warm(uVar1,param1);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  uVar1 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar1,StringLiteral_3179,StringLiteral_1773,0);
		  uVar1 = Utils_LocalProps___ctor(uVar1,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F8F")]
		[Address(RVA = "0x9DAC", Offset = "0x9DAC", VA = "0x9DAC")]
		public PreloaderFetcher(ICurrentTimeProvider timeProvider, IDictProvider dictProvider, IGameAssetProvider assetProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AssetsPrefetch_PreloaderFetcher___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a589d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PreloaderFetcher__Fetch_d__8___
		              );
		    DAT_ram_00a589d1 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_PreloaderBackgroundLoader__Awake_d__3_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PreloaderFetcher__Fetch_d__8___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F90")]
		[Address(RVA = "0x1D7A", Offset = "0x1D7A", VA = "0x1D7A")]
		private void Reset()
		{
		/* --- GHIDRA: Reset ---
		undefined4 Gameplay_AssetsPrefetch_PreloaderFetcher__Reset(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x2c);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (*(int *)(param1_00 + 0xc) < 1) {
		    uVar2 = 0;
		  }
		  else {
		    while (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                             (param1_00,param2_00,
		                              Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                             ), *(int *)(iVar1 + 0xc) != 0xe2) {
		      param2_00 = param2_00 + 1;
		      if (*(int *)(param1_00 + 0xc) <= param2_00) {
		        return 0;
		      }
		    }
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F91")]
		[Address(RVA = "0x9DAD", Offset = "0x9DAD", VA = "0x9DAD")]
		public void Fetch()
		{
		/* --- GHIDRA: Fetch ---
		void Gameplay_AssetsPrefetch_PreloaderFetcher__Fetch(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a589d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AssetsPrefetch_PreloaderFetcher___c_TypeInfo);
		    DAT_ram_00a589d2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_AssetsPrefetch_PreloaderFetcher___c_TypeInfo);
		  **(undefined4 **)(Gameplay_AssetsPrefetch_PreloaderFetcher___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x8")]
		private readonly ICurrentTimeProvider _timeProvider;

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x10")]
		private readonly IGameAssetProvider _assetProvider;

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x14")]
		private readonly AssetsPrefetch _assetsPrefetch;

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalProps _localProps;
	}
}
