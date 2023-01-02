; ModuleID = 'obj\Release\130\android\compressed_assemblies.armeabi-v7a.ll'
source_filename = "obj\Release\130\android\compressed_assemblies.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [153088 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [169472 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [1537536 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [121856 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [690176 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [232448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [120320 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [110592 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [376320 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [747008 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [218112 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [38912 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [6144 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [65024 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [1318912 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [839168 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [15280 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [23984 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [58256 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [1080720 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [57344 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [318464 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [26112 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [168960 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [9216 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_25 = internal global [40960 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_26 = internal global [197120 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_27 = internal global [15360 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_28 = internal global [16384 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_29 = internal global [17408 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_30 = internal global [36864 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_31 = internal global [13312 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_32 = internal global [16384 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_33 = internal global [28672 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_34 = internal global [21880 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_35 = internal global [13824 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_36 = internal global [251904 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_37 = internal global [50176 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_38 = internal global [142256 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_39 = internal global [15264 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_40 = internal global [2029992 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_41 = internal global [2008576 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [42 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 153088, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([153088 x i8], [153088 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 169472, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([169472 x i8], [169472 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 1537536, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1537536 x i8], [1537536 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 121856, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([121856 x i8], [121856 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 690176, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([690176 x i8], [690176 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 232448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([232448 x i8], [232448 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 120320, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([120320 x i8], [120320 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 110592, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([110592 x i8], [110592 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 376320, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([376320 x i8], [376320 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 747008, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([747008 x i8], [747008 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 218112, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([218112 x i8], [218112 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 38912, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([38912 x i8], [38912 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6144 x i8], [6144 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 65024, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([65024 x i8], [65024 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 1318912, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1318912 x i8], [1318912 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 839168, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([839168 x i8], [839168 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 15280, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15280 x i8], [15280 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 23984, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([23984 x i8], [23984 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 58256, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([58256 x i8], [58256 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 1080720, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1080720 x i8], [1080720 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 57344, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([57344 x i8], [57344 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 318464, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([318464 x i8], [318464 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 26112, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([26112 x i8], [26112 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 168960, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([168960 x i8], [168960 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 9216, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([9216 x i8], [9216 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}, 
	; 25
	%struct.CompressedAssemblyDescriptor {
		i32 40960, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([40960 x i8], [40960 x i8]* @__CompressedAssemblyDescriptor_data_25, i32 0, i32 0); data
	}, 
	; 26
	%struct.CompressedAssemblyDescriptor {
		i32 197120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([197120 x i8], [197120 x i8]* @__CompressedAssemblyDescriptor_data_26, i32 0, i32 0); data
	}, 
	; 27
	%struct.CompressedAssemblyDescriptor {
		i32 15360, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15360 x i8], [15360 x i8]* @__CompressedAssemblyDescriptor_data_27, i32 0, i32 0); data
	}, 
	; 28
	%struct.CompressedAssemblyDescriptor {
		i32 16384, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16384 x i8], [16384 x i8]* @__CompressedAssemblyDescriptor_data_28, i32 0, i32 0); data
	}, 
	; 29
	%struct.CompressedAssemblyDescriptor {
		i32 17408, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([17408 x i8], [17408 x i8]* @__CompressedAssemblyDescriptor_data_29, i32 0, i32 0); data
	}, 
	; 30
	%struct.CompressedAssemblyDescriptor {
		i32 36864, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36864 x i8], [36864 x i8]* @__CompressedAssemblyDescriptor_data_30, i32 0, i32 0); data
	}, 
	; 31
	%struct.CompressedAssemblyDescriptor {
		i32 13312, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([13312 x i8], [13312 x i8]* @__CompressedAssemblyDescriptor_data_31, i32 0, i32 0); data
	}, 
	; 32
	%struct.CompressedAssemblyDescriptor {
		i32 16384, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16384 x i8], [16384 x i8]* @__CompressedAssemblyDescriptor_data_32, i32 0, i32 0); data
	}, 
	; 33
	%struct.CompressedAssemblyDescriptor {
		i32 28672, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([28672 x i8], [28672 x i8]* @__CompressedAssemblyDescriptor_data_33, i32 0, i32 0); data
	}, 
	; 34
	%struct.CompressedAssemblyDescriptor {
		i32 21880, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([21880 x i8], [21880 x i8]* @__CompressedAssemblyDescriptor_data_34, i32 0, i32 0); data
	}, 
	; 35
	%struct.CompressedAssemblyDescriptor {
		i32 13824, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([13824 x i8], [13824 x i8]* @__CompressedAssemblyDescriptor_data_35, i32 0, i32 0); data
	}, 
	; 36
	%struct.CompressedAssemblyDescriptor {
		i32 251904, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([251904 x i8], [251904 x i8]* @__CompressedAssemblyDescriptor_data_36, i32 0, i32 0); data
	}, 
	; 37
	%struct.CompressedAssemblyDescriptor {
		i32 50176, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([50176 x i8], [50176 x i8]* @__CompressedAssemblyDescriptor_data_37, i32 0, i32 0); data
	}, 
	; 38
	%struct.CompressedAssemblyDescriptor {
		i32 142256, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([142256 x i8], [142256 x i8]* @__CompressedAssemblyDescriptor_data_38, i32 0, i32 0); data
	}, 
	; 39
	%struct.CompressedAssemblyDescriptor {
		i32 15264, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15264 x i8], [15264 x i8]* @__CompressedAssemblyDescriptor_data_39, i32 0, i32 0); data
	}, 
	; 40
	%struct.CompressedAssemblyDescriptor {
		i32 2029992, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2029992 x i8], [2029992 x i8]* @__CompressedAssemblyDescriptor_data_40, i32 0, i32 0); data
	}, 
	; 41
	%struct.CompressedAssemblyDescriptor {
		i32 2008576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2008576 x i8], [2008576 x i8]* @__CompressedAssemblyDescriptor_data_41, i32 0, i32 0); data
	}
], align 4; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 42, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([42 x %struct.CompressedAssemblyDescriptor], [42 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 4


!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/main @ 7c9c24b3614710614c5512d7a3b8272065270dc2"}
