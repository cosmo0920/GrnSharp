using System;
using System.Runtime.InteropServices;

public partial class NativeConstants {
    
    /// GROONGA_H -> 
    /// Error generating expression: 値を Null にすることはできません。
    ///パラメータ名: node
    public const string GROONGA_H = "";
    
    /// GRN_ID_NIL -> (0x00)
    public const int GRN_ID_NIL = 0;
    
    /// GRN_ID_MAX -> (0x3fffffff)
    public const int GRN_ID_MAX = 1073741823;
    
    /// GRN_TRUE -> (1)
    public const int GRN_TRUE = 1;
    
    /// GRN_FALSE -> (0)
    public const int GRN_FALSE = 0;
    
    /// GRN_COMMAND_VERSION_MIN -> GRN_COMMAND_VERSION_1
    public const grn_command_version GRN_COMMAND_VERSION_MIN = grn_command_version.GRN_COMMAND_VERSION_1;
    
    /// GRN_COMMAND_VERSION_STABLE -> GRN_COMMAND_VERSION_1
    public const grn_command_version GRN_COMMAND_VERSION_STABLE = grn_command_version.GRN_COMMAND_VERSION_1;
    
    /// GRN_COMMAND_VERSION_MAX -> GRN_COMMAND_VERSION_2
    public const grn_command_version GRN_COMMAND_VERSION_MAX = grn_command_version.GRN_COMMAND_VERSION_2;
    
    /// GRN_QUERY_LOG_NONE -> (0x00)
    public const int GRN_QUERY_LOG_NONE = 0;
    
    /// GRN_QUERY_LOG_COMMAND -> (0x01<<0)
    public const int GRN_QUERY_LOG_COMMAND = (1) << (0);
    
    /// GRN_QUERY_LOG_RESULT_CODE -> (0x01<<1)
    public const int GRN_QUERY_LOG_RESULT_CODE = (1) << (1);
    
    /// GRN_QUERY_LOG_DESTINATION -> (0x01<<2)
    public const int GRN_QUERY_LOG_DESTINATION = (1) << (2);
    
    /// GRN_QUERY_LOG_CACHE -> (0x01<<3)
    public const int GRN_QUERY_LOG_CACHE = (1) << (3);
    
    /// GRN_QUERY_LOG_SIZE -> (0x01<<4)
    public const int GRN_QUERY_LOG_SIZE = (1) << (4);
    
    /// GRN_QUERY_LOG_SCORE -> (0x01<<5)
    public const int GRN_QUERY_LOG_SCORE = (1) << (5);
    
    /// GRN_QUERY_LOG_ALL -> (GRN_QUERY_LOG_COMMAND |   GRN_QUERY_LOG_RESULT_CODE |   GRN_QUERY_LOG_DESTINATION |   GRN_QUERY_LOG_CACHE |   GRN_QUERY_LOG_SIZE |   GRN_QUERY_LOG_SCORE)
    public const int GRN_QUERY_LOG_ALL = (NativeConstants.GRN_QUERY_LOG_COMMAND 
                | (NativeConstants.GRN_QUERY_LOG_RESULT_CODE 
                | (NativeConstants.GRN_QUERY_LOG_DESTINATION 
                | (NativeConstants.GRN_QUERY_LOG_CACHE 
                | (NativeConstants.GRN_QUERY_LOG_SIZE | NativeConstants.GRN_QUERY_LOG_SCORE)))));
    
    /// GRN_QUERY_LOG_DEFAULT -> GRN_QUERY_LOG_ALL
    public const int GRN_QUERY_LOG_DEFAULT = NativeConstants.GRN_QUERY_LOG_ALL;
    
    /// GRN_CTX_MSGSIZE -> (0x80)
    public const int GRN_CTX_MSGSIZE = 128;
    
    /// GRN_CTX_FIN -> (0xff)
    public const int GRN_CTX_FIN = 255;
    
    /// GRN_CTX_USE_QL -> (0x03)
    public const int GRN_CTX_USE_QL = 3;
    
    /// GRN_CTX_BATCH_MODE -> (0x04)
    public const int GRN_CTX_BATCH_MODE = 4;
    
    /// GRN_CTX_PER_DB -> (0x08)
    public const int GRN_CTX_PER_DB = 8;
    
    /// GRN_CACHE_DEFAULT_MAX_N_ENTRIES -> 100
    public const int GRN_CACHE_DEFAULT_MAX_N_ENTRIES = 100;
    
    /// GRN_OBJ_TABLE_TYPE_MASK -> (0x07)
    public const int GRN_OBJ_TABLE_TYPE_MASK = 7;
    
    /// GRN_OBJ_TABLE_HASH_KEY -> (0x00)
    public const int GRN_OBJ_TABLE_HASH_KEY = 0;
    
    /// GRN_OBJ_TABLE_PAT_KEY -> (0x01)
    public const int GRN_OBJ_TABLE_PAT_KEY = 1;
    
    /// GRN_OBJ_TABLE_DAT_KEY -> (0x02)
    public const int GRN_OBJ_TABLE_DAT_KEY = 2;
    
    /// GRN_OBJ_TABLE_NO_KEY -> (0x03)
    public const int GRN_OBJ_TABLE_NO_KEY = 3;
    
    /// GRN_OBJ_KEY_MASK -> (0x07<<3)
    public const int GRN_OBJ_KEY_MASK = (7) << (3);
    
    /// GRN_OBJ_KEY_UINT -> (0x00<<3)
    public const int GRN_OBJ_KEY_UINT = (0) << (3);
    
    /// GRN_OBJ_KEY_INT -> (0x01<<3)
    public const int GRN_OBJ_KEY_INT = (1) << (3);
    
    /// GRN_OBJ_KEY_FLOAT -> (0x02<<3)
    public const int GRN_OBJ_KEY_FLOAT = (2) << (3);
    
    /// GRN_OBJ_KEY_GEO_POINT -> (0x03<<3)
    public const int GRN_OBJ_KEY_GEO_POINT = (3) << (3);
    
    /// GRN_OBJ_KEY_WITH_SIS -> (0x01<<6)
    public const int GRN_OBJ_KEY_WITH_SIS = (1) << (6);
    
    /// GRN_OBJ_KEY_NORMALIZE -> (0x01<<7)
    public const int GRN_OBJ_KEY_NORMALIZE = (1) << (7);
    
    /// GRN_OBJ_COLUMN_TYPE_MASK -> (0x07)
    public const int GRN_OBJ_COLUMN_TYPE_MASK = 7;
    
    /// GRN_OBJ_COLUMN_SCALAR -> (0x00)
    public const int GRN_OBJ_COLUMN_SCALAR = 0;
    
    /// GRN_OBJ_COLUMN_VECTOR -> (0x01)
    public const int GRN_OBJ_COLUMN_VECTOR = 1;
    
    /// GRN_OBJ_COLUMN_INDEX -> (0x02)
    public const int GRN_OBJ_COLUMN_INDEX = 2;
    
    /// GRN_OBJ_COMPRESS_MASK -> (0x07<<4)
    public const int GRN_OBJ_COMPRESS_MASK = (7) << (4);
    
    /// GRN_OBJ_COMPRESS_NONE -> (0x00<<4)
    public const int GRN_OBJ_COMPRESS_NONE = (0) << (4);
    
    /// GRN_OBJ_COMPRESS_ZLIB -> (0x01<<4)
    public const int GRN_OBJ_COMPRESS_ZLIB = (1) << (4);
    
    /// GRN_OBJ_COMPRESS_LZO -> (0x02<<4)
    public const int GRN_OBJ_COMPRESS_LZO = (2) << (4);
    
    /// GRN_OBJ_WITH_SECTION -> (0x01<<7)
    public const int GRN_OBJ_WITH_SECTION = (1) << (7);
    
    /// GRN_OBJ_WITH_WEIGHT -> (0x01<<8)
    public const int GRN_OBJ_WITH_WEIGHT = (1) << (8);
    
    /// GRN_OBJ_WITH_POSITION -> (0x01<<9)
    public const int GRN_OBJ_WITH_POSITION = (1) << (9);
    
    /// GRN_OBJ_RING_BUFFER -> (0x01<<10)
    public const int GRN_OBJ_RING_BUFFER = (1) << (10);
    
    /// GRN_OBJ_UNIT_MASK -> (0x0f<<8)
    public const int GRN_OBJ_UNIT_MASK = (15) << (8);
    
    /// GRN_OBJ_UNIT_DOCUMENT_NONE -> (0x00<<8)
    public const int GRN_OBJ_UNIT_DOCUMENT_NONE = (0) << (8);
    
    /// GRN_OBJ_UNIT_DOCUMENT_SECTION -> (0x01<<8)
    public const int GRN_OBJ_UNIT_DOCUMENT_SECTION = (1) << (8);
    
    /// GRN_OBJ_UNIT_DOCUMENT_POSITION -> (0x02<<8)
    public const int GRN_OBJ_UNIT_DOCUMENT_POSITION = (2) << (8);
    
    /// GRN_OBJ_UNIT_SECTION_NONE -> (0x03<<8)
    public const int GRN_OBJ_UNIT_SECTION_NONE = (3) << (8);
    
    /// GRN_OBJ_UNIT_SECTION_POSITION -> (0x04<<8)
    public const int GRN_OBJ_UNIT_SECTION_POSITION = (4) << (8);
    
    /// GRN_OBJ_UNIT_POSITION_NONE -> (0x05<<8)
    public const int GRN_OBJ_UNIT_POSITION_NONE = (5) << (8);
    
    /// GRN_OBJ_UNIT_USERDEF_DOCUMENT -> (0x06<<8)
    public const int GRN_OBJ_UNIT_USERDEF_DOCUMENT = (6) << (8);
    
    /// GRN_OBJ_UNIT_USERDEF_SECTION -> (0x07<<8)
    public const int GRN_OBJ_UNIT_USERDEF_SECTION = (7) << (8);
    
    /// GRN_OBJ_UNIT_USERDEF_POSITION -> (0x08<<8)
    public const int GRN_OBJ_UNIT_USERDEF_POSITION = (8) << (8);
    
    /// GRN_OBJ_NO_SUBREC -> (0x00<<13)
    public const int GRN_OBJ_NO_SUBREC = (0) << (13);
    
    /// GRN_OBJ_WITH_SUBREC -> (0x01<<13)
    public const int GRN_OBJ_WITH_SUBREC = (1) << (13);
    
    /// GRN_OBJ_KEY_VAR_SIZE -> (0x01<<14)
    public const int GRN_OBJ_KEY_VAR_SIZE = (1) << (14);
    
    /// GRN_OBJ_TEMPORARY -> (0x00<<15)
    public const int GRN_OBJ_TEMPORARY = (0) << (15);
    
    /// GRN_OBJ_PERSISTENT -> (0x01<<15)
    public const int GRN_OBJ_PERSISTENT = (1) << (15);
    
    /// GRN_VOID -> (0x00)
    public const int GRN_VOID = 0;
    
    /// GRN_BULK -> (0x02)
    public const int GRN_BULK = 2;
    
    /// GRN_PTR -> (0x03)
    public const int GRN_PTR = 3;
    
    /// GRN_UVECTOR -> (0x04)
    public const int GRN_UVECTOR = 4;
    
    /// GRN_PVECTOR -> (0x05)
    public const int GRN_PVECTOR = 5;
    
    /// GRN_VECTOR -> (0x06)
    public const int GRN_VECTOR = 6;
    
    /// GRN_MSG -> (0x07)
    public const int GRN_MSG = 7;
    
    /// GRN_QUERY -> (0x08)
    public const int GRN_QUERY = 8;
    
    /// GRN_ACCESSOR -> (0x09)
    public const int GRN_ACCESSOR = 9;
    
    /// GRN_SNIP -> (0x0b)
    public const int GRN_SNIP = 11;
    
    /// GRN_PATSNIP -> (0x0c)
    public const int GRN_PATSNIP = 12;
    
    /// GRN_STRING -> (0x0d)
    public const int GRN_STRING = 13;
    
    /// GRN_CURSOR_TABLE_HASH_KEY -> (0x10)
    public const int GRN_CURSOR_TABLE_HASH_KEY = 16;
    
    /// GRN_CURSOR_TABLE_PAT_KEY -> (0x11)
    public const int GRN_CURSOR_TABLE_PAT_KEY = 17;
    
    /// GRN_CURSOR_TABLE_DAT_KEY -> (0x12)
    public const int GRN_CURSOR_TABLE_DAT_KEY = 18;
    
    /// GRN_CURSOR_TABLE_NO_KEY -> (0x13)
    public const int GRN_CURSOR_TABLE_NO_KEY = 19;
    
    /// GRN_CURSOR_COLUMN_INDEX -> (0x18)
    public const int GRN_CURSOR_COLUMN_INDEX = 24;
    
    /// GRN_CURSOR_COLUMN_GEO_INDEX -> (0x1a)
    public const int GRN_CURSOR_COLUMN_GEO_INDEX = 26;
    
    /// GRN_TYPE -> (0x20)
    public const int GRN_TYPE = 32;
    
    /// GRN_PROC -> (0x21)
    public const int GRN_PROC = 33;
    
    /// GRN_EXPR -> (0x22)
    public const int GRN_EXPR = 34;
    
    /// GRN_TABLE_HASH_KEY -> (0x30)
    public const int GRN_TABLE_HASH_KEY = 48;
    
    /// GRN_TABLE_PAT_KEY -> (0x31)
    public const int GRN_TABLE_PAT_KEY = 49;
    
    /// GRN_TABLE_DAT_KEY -> (0x32)
    public const int GRN_TABLE_DAT_KEY = 50;
    
    /// GRN_TABLE_NO_KEY -> (0x33)
    public const int GRN_TABLE_NO_KEY = 51;
    
    /// GRN_DB -> (0x37)
    public const int GRN_DB = 55;
    
    /// GRN_COLUMN_FIX_SIZE -> (0x40)
    public const int GRN_COLUMN_FIX_SIZE = 64;
    
    /// GRN_COLUMN_VAR_SIZE -> (0x41)
    public const int GRN_COLUMN_VAR_SIZE = 65;
    
    /// GRN_COLUMN_INDEX -> (0x48)
    public const int GRN_COLUMN_INDEX = 72;
    
    /// GRN_OBJ_REFER -> (0x01<<0)
    public const int GRN_OBJ_REFER = (1) << (0);
    
    /// GRN_OBJ_OUTPLACE -> (0x01<<1)
    public const int GRN_OBJ_OUTPLACE = (1) << (1);
    
    /// GRN_TABLE_MAX_KEY_SIZE -> (0x1000)
    public const int GRN_TABLE_MAX_KEY_SIZE = 4096;
    
    /// GRN_CURSOR_ASCENDING -> (0x00<<0)
    public const int GRN_CURSOR_ASCENDING = (0) << (0);
    
    /// GRN_CURSOR_DESCENDING -> (0x01<<0)
    public const int GRN_CURSOR_DESCENDING = (1) << (0);
    
    /// GRN_CURSOR_GE -> (0x00<<1)
    public const int GRN_CURSOR_GE = (0) << (1);
    
    /// GRN_CURSOR_GT -> (0x01<<1)
    public const int GRN_CURSOR_GT = (1) << (1);
    
    /// GRN_CURSOR_LE -> (0x00<<2)
    public const int GRN_CURSOR_LE = (0) << (2);
    
    /// GRN_CURSOR_LT -> (0x01<<2)
    public const int GRN_CURSOR_LT = (1) << (2);
    
    /// GRN_CURSOR_BY_KEY -> (0x00<<3)
    public const int GRN_CURSOR_BY_KEY = (0) << (3);
    
    /// GRN_CURSOR_BY_ID -> (0x01<<3)
    public const int GRN_CURSOR_BY_ID = (1) << (3);
    
    /// GRN_CURSOR_PREFIX -> (0x01<<4)
    public const int GRN_CURSOR_PREFIX = (1) << (4);
    
    /// GRN_CURSOR_SIZE_BY_BIT -> (0x01<<5)
    public const int GRN_CURSOR_SIZE_BY_BIT = (1) << (5);
    
    /// GRN_CURSOR_RK -> (0x01<<6)
    public const int GRN_CURSOR_RK = (1) << (6);
    
    /// GRN_TABLE_SORT_ASC -> (0x00<<0)
    public const int GRN_TABLE_SORT_ASC = (0) << (0);
    
    /// GRN_TABLE_SORT_DESC -> (0x01<<0)
    public const int GRN_TABLE_SORT_DESC = (1) << (0);
    
    /// GRN_TABLE_GROUP_CALC_COUNT -> (0x01<<3)
    public const int GRN_TABLE_GROUP_CALC_COUNT = (1) << (3);
    
    /// GRN_TABLE_GROUP_CALC_MAX -> (0x01<<4)
    public const int GRN_TABLE_GROUP_CALC_MAX = (1) << (4);
    
    /// GRN_TABLE_GROUP_CALC_MIN -> (0x01<<5)
    public const int GRN_TABLE_GROUP_CALC_MIN = (1) << (5);
    
    /// GRN_TABLE_GROUP_CALC_SUM -> (0x01<<6)
    public const int GRN_TABLE_GROUP_CALC_SUM = (1) << (6);
    
    /// GRN_TABLE_GROUP_CALC_AVG -> (0x01<<7)
    public const int GRN_TABLE_GROUP_CALC_AVG = (1) << (7);
    
    /// GRN_OP_BUT -> GRN_OP_AND_NOT
    public const grn_operator GRN_OP_BUT = grn_operator.GRN_OP_AND_NOT;
    
    /// GRN_COLUMN_NAME_ID -> "_id"
    public const string GRN_COLUMN_NAME_ID = "_id";
    
    /// GRN_COLUMN_NAME_KEY -> "_key"
    public const string GRN_COLUMN_NAME_KEY = "_key";
    
    /// GRN_COLUMN_NAME_VALUE -> "_value"
    public const string GRN_COLUMN_NAME_VALUE = "_value";
    
    /// GRN_COLUMN_NAME_SCORE -> "_score"
    public const string GRN_COLUMN_NAME_SCORE = "_score";
    
    /// GRN_COLUMN_NAME_NSUBRECS -> "_nsubrecs"
    public const string GRN_COLUMN_NAME_NSUBRECS = "_nsubrecs";
    
    /// GRN_OBJ_SET_MASK -> (0x07)
    public const int GRN_OBJ_SET_MASK = 7;
    
    /// GRN_OBJ_SET -> (0x01)
    public const int GRN_OBJ_SET = 1;
    
    /// GRN_OBJ_INCR -> (0x02)
    public const int GRN_OBJ_INCR = 2;
    
    /// GRN_OBJ_DECR -> (0x03)
    public const int GRN_OBJ_DECR = 3;
    
    /// GRN_OBJ_APPEND -> (0x04)
    public const int GRN_OBJ_APPEND = 4;
    
    /// GRN_OBJ_PREPEND -> (0x05)
    public const int GRN_OBJ_PREPEND = 5;
    
    /// GRN_OBJ_GET -> (0x01<<4)
    public const int GRN_OBJ_GET = (1) << (4);
    
    /// GRN_OBJ_COMPARE -> (0x01<<5)
    public const int GRN_OBJ_COMPARE = (1) << (5);
    
    /// GRN_OBJ_LOCK -> (0x01<<6)
    public const int GRN_OBJ_LOCK = (1) << (6);
    
    /// GRN_OBJ_UNLOCK -> (0x01<<7)
    public const int GRN_OBJ_UNLOCK = (1) << (7);
    
    /// GRN_QUERY_AND -> '+'
    public const char GRN_QUERY_AND = '+';
    
    /// GRN_QUERY_AND_NOT -> '-'
    public const char GRN_QUERY_AND_NOT = '-';
    
    /// GRN_QUERY_ADJ_INC -> '>'
    public const char GRN_QUERY_ADJ_INC = '>';
    
    /// GRN_QUERY_ADJ_DEC -> '<'
    public const char GRN_QUERY_ADJ_DEC = '<';
    
    /// GRN_QUERY_ADJ_NEG -> '~'
    public const char GRN_QUERY_ADJ_NEG = '~';
    
    /// GRN_QUERY_PREFIX -> '*'
    public const char GRN_QUERY_PREFIX = '*';
    
    /// GRN_QUERY_PARENL -> '('
    public const char GRN_QUERY_PARENL = '(';
    
    /// GRN_QUERY_PARENR -> ')'
    public const char GRN_QUERY_PARENR = ')';
    
    /// GRN_QUERY_QUOTEL -> '"'
    public const char GRN_QUERY_QUOTEL = '\"';
    
    /// GRN_QUERY_QUOTER -> '"'
    public const char GRN_QUERY_QUOTER = '\"';
    
    /// GRN_QUERY_ESCAPE -> '\\'
    public const char GRN_QUERY_ESCAPE = '\\';
    
    /// GRN_QUERY_COLUMN -> ':'
    public const char GRN_QUERY_COLUMN = ':';
    
    /// GRN_SNIP_NORMALIZE -> (0x01<<0)
    public const int GRN_SNIP_NORMALIZE = (1) << (0);
    
    /// GRN_SNIP_COPY_TAG -> (0x01<<1)
    public const int GRN_SNIP_COPY_TAG = (1) << (1);
    
    /// GRN_SNIP_SKIP_LEADING_SPACES -> (0x01<<2)
    public const int GRN_SNIP_SKIP_LEADING_SPACES = (1) << (2);
    
    /// GRN_LOG_TIME -> (0x01<<0)
    public const int GRN_LOG_TIME = (1) << (0);
    
    /// GRN_LOG_TITLE -> (0x01<<1)
    public const int GRN_LOG_TITLE = (1) << (1);
    
    /// GRN_LOG_MESSAGE -> (0x01<<2)
    public const int GRN_LOG_MESSAGE = (1) << (2);
    
    /// GRN_LOG_LOCATION -> (0x01<<3)
    public const int GRN_LOG_LOCATION = (1) << (3);
    
    /// GRN_LOG_DEFAULT_LEVEL -> GRN_LOG_NOTICE
    public const grn_log_level GRN_LOG_DEFAULT_LEVEL = grn_log_level.GRN_LOG_NOTICE;
    
    /// GRN_BULK_BUFSIZE_MAX -> 0x1f
    public const int GRN_BULK_BUFSIZE_MAX = 31;
    
    /// GRN_OBJ_FORMAT_WITH_COLUMN_NAMES -> (0x01<<0)
    public const int GRN_OBJ_FORMAT_WITH_COLUMN_NAMES = (1) << (0);
    
    /// GRN_OBJ_FORMAT_AS_ARRAY -> (0x01<<3)
    public const int GRN_OBJ_FORMAT_AS_ARRAY = (1) << (3);
    
    /// GRN_OBJ_FORMAT_ASARRAY -> GRN_OBJ_FORMAT_AS_ARRAY
    public const int GRN_OBJ_FORMAT_ASARRAY = NativeConstants.GRN_OBJ_FORMAT_AS_ARRAY;
    
    /// GRN_OBJ_FORMAT_WITH_WEIGHT -> (0x01<<4)
    public const int GRN_OBJ_FORMAT_WITH_WEIGHT = (1) << (4);

	/// GRN_OBJ_DO_SHALLOW_COPY -> (GRN_OBJ_REFER|GRN_OBJ_OUTPLACE)
    public const int GRN_OBJ_DO_SHALLOW_COPY = (NativeConstants.GRN_OBJ_REFER | NativeConstants.GRN_OBJ_OUTPLACE);
    
    /// GRN_OBJ_VECTOR -> (0x01<<7)
    public const int GRN_OBJ_VECTOR = (1) << (7);
    
    /// GRN_TIME_USEC_PER_SEC -> 1000000
    public const int GRN_TIME_USEC_PER_SEC = 1000000;
    
    /// GRN_STR_REMOVEBLANK -> (0x01<<0)
    public const int GRN_STR_REMOVEBLANK = (1) << (0);
    
    /// GRN_STR_WITH_CTYPES -> (0x01<<1)
    public const int GRN_STR_WITH_CTYPES = (1) << (1);
    
    /// GRN_STR_WITH_CHECKS -> (0x01<<2)
    public const int GRN_STR_WITH_CHECKS = (1) << (2);
    
    /// GRN_STR_NORMALIZE -> GRN_OBJ_KEY_NORMALIZE
    public const int GRN_STR_NORMALIZE = NativeConstants.GRN_OBJ_KEY_NORMALIZE;
    
    /// GRN_STRING_REMOVE_BLANK -> (0x01<<0)
    public const int GRN_STRING_REMOVE_BLANK = (1) << (0);
    
    /// GRN_STRING_WITH_TYPES -> (0x01<<1)
    public const int GRN_STRING_WITH_TYPES = (1) << (1);
    
    /// GRN_STRING_WITH_CHECKS -> (0x01<<2)
    public const int GRN_STRING_WITH_CHECKS = (1) << (2);
    
    /// GRN_STRING_REMOVE_TOKENIZED_DELIMITER -> (0x01<<3)
    public const int GRN_STRING_REMOVE_TOKENIZED_DELIMITER = (1) << (3);
    
    /// GRN_NORMALIZER_AUTO -> ((grn_obj *)1)
    /// Error generating expression: Expression is not parsable.  Treating value as a raw string
    public const string GRN_NORMALIZER_AUTO = "((grn_obj *)1)";
    
    /// GRN_CHAR_BLANK -> 0x80
    public const int GRN_CHAR_BLANK = 128;
    
    /// GRN_EXPR_SYNTAX_QUERY -> (0x00)
    public const int GRN_EXPR_SYNTAX_QUERY = 0;
    
    /// GRN_EXPR_SYNTAX_SCRIPT -> (0x01)
    public const int GRN_EXPR_SYNTAX_SCRIPT = 1;
    
    /// GRN_EXPR_SYNTAX_OUTPUT_COLUMNS -> (0x20)
    public const int GRN_EXPR_SYNTAX_OUTPUT_COLUMNS = 32;
    
    /// GRN_EXPR_SYNTAX_ADJUSTER -> (0x40)
    public const int GRN_EXPR_SYNTAX_ADJUSTER = 64;
    
    /// GRN_EXPR_ALLOW_PRAGMA -> (0x02)
    public const int GRN_EXPR_ALLOW_PRAGMA = 2;
    
    /// GRN_EXPR_ALLOW_COLUMN -> (0x04)
    public const int GRN_EXPR_ALLOW_COLUMN = 4;
    
    /// GRN_EXPR_ALLOW_UPDATE -> (0x08)
    public const int GRN_EXPR_ALLOW_UPDATE = 8;
    
    /// GRN_EXPR_ALLOW_LEADING_NOT -> (0x10)
    public const int GRN_EXPR_ALLOW_LEADING_NOT = 16;
    
    /// GRN_CTX_MORE -> (0x01<<0)
    public const int GRN_CTX_MORE = (1) << (0);
    
    /// GRN_CTX_TAIL -> (0x01<<1)
    public const int GRN_CTX_TAIL = (1) << (1);
    
    /// GRN_CTX_HEAD -> (0x01<<2)
    public const int GRN_CTX_HEAD = (1) << (2);
    
    /// GRN_CTX_QUIET -> (0x01<<3)
    public const int GRN_CTX_QUIET = (1) << (3);
    
    /// GRN_CTX_QUIT -> (0x01<<4)
    public const int GRN_CTX_QUIT = (1) << (4);
}

/// Return Type: grn_obj*
///ctx: grn_ctx*
///nargs: int
///args: grn_obj**
///user_data: grn_user_data*
public delegate System.IntPtr grn_proc_func(ref grn_ctx ctx, int nargs, ref System.IntPtr args, ref grn_user_data user_data);

[StructLayoutAttribute(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
public struct grn_ctx {
    
    /// grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    public grn_rc rc;
    
    /// int
    public int flags;
    
    /// grn_encoding->Anonymous_4cc9cdbc_7025_4e0d_86b2_46372051bb24
    public grn_encoding encoding;
    
    /// unsigned char
    public byte ntrace;
    
    /// unsigned char
    public byte errlvl;
    
    /// unsigned char
    public byte stat;
    
    /// unsigned int
    public uint seqno;
    
    /// unsigned int
    public uint subno;
    
    /// unsigned int
    public uint seqno2;
    
    /// unsigned int
    public uint errline;
    
    /// grn_user_data->Anonymous_6787273e_3d62_4061_a857_bd9685b7c6cc
    public grn_user_data user_data;
    
    /// grn_ctx*
    public System.IntPtr prev;
    
    /// grn_ctx*
    public System.IntPtr next;
    
    /// char*
    [MarshalAsAttribute(UnmanagedType.LPStr)]
    public string errfile;
    
    /// char*
    [MarshalAsAttribute(UnmanagedType.LPStr)]
    public string errfunc;
    
    /// _grn_ctx_impl*
    public System.IntPtr impl;
    
    /// void*[16]
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst=16, ArraySubType=UnmanagedType.SysUInt)]
    public System.IntPtr[] trace;
    
    /// char[128]
    [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst=128)]
    public string errbuf;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_section {
    
    /// unsigned int
    public uint offset;
    
    /// unsigned int
    public uint length;
    
    /// unsigned int
    public uint weight;
    
    /// grn_id->unsigned int
    public uint domain;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_obj_header {
    
    /// unsigned char
    public byte type;
    
    /// unsigned char
    public byte impl_flags;
    
    /// grn_obj_flags->unsigned short
    public ushort flags;
    
    /// grn_id->unsigned int
    public uint domain;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_table_cursor {
    
    /// grn_obj_header->_grn_obj_header
    public grn_obj_header header;
    
    /// Anonymous_4694aee7_1960_4616_aea1_b13a0d4c24ff
    public Anonymous_table_cursor_union u;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_db_create_optarg {
    
    /// char**
    public System.IntPtr builtin_type_names;
    
    /// int
    public int n_builtin_type_names;
}

/// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
///ctx: grn_ctx*
public delegate grn_rc grn_plugin_func(ref grn_ctx ctx);

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_table_sort_key {
    
    /// grn_obj*
    public System.IntPtr key;
    
    /// grn_table_sort_flags->unsigned char
    public byte flags;
    
    /// int
    public int offset;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_table_group_result {
    
    /// grn_obj*
    public System.IntPtr table;
    
    /// unsigned char
    public byte key_begin;
    
    /// unsigned char
    public byte key_end;
    
    /// int
    public int limit;
    
    /// grn_table_group_flags->unsigned int
    public uint flags;
    
    /// grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    public grn_operator op;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_search_optarg {
    
    /// grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    public grn_operator mode;
    
    /// int
    public int similarity_threshold;
    
    /// int
    public int max_interval;
    
    /// int*
    public System.IntPtr weight_vector;
    
    /// int
    public int vector_size;
    
    /// grn_obj*
    public System.IntPtr proc;
    
    /// int
    public int max_size;
}

/// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
///ctx: grn_ctx*
///table: grn_obj*
///index: grn_obj*
///nargs: int
///args: grn_obj**
///res: grn_obj*
///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
public delegate grn_rc grn_selector_func(ref grn_ctx ctx, ref grn_table_cursor table, ref grn_table_cursor index, int nargs, ref System.IntPtr args, ref grn_table_cursor res, grn_operator op);

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_snip_mapping {
    
    /// void*
    public System.IntPtr dummy;
}

/// Return Type: void
///param0: int
///param1: char*
///param2: char*
///param3: char*
///param4: char*
///param5: void*
public delegate void _grn_logger_info_func(int param0, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string param1, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string param2, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string param3, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string param4, System.IntPtr param5);

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_logger_info {
    
    /// grn_log_level->Anonymous_1ceaa881_6549_4381_9e76_6c322e07a4ce
    public grn_log_level max_level;
    
    /// int
    public int flags;
    
    /// _grn_logger_info_func
    public _grn_logger_info_func AnonymousMember1;
    
    /// void*
    public System.IntPtr func_arg;
}

/// Return Type: void
///ctx: grn_ctx*
///level: grn_log_level->Anonymous_1ceaa881_6549_4381_9e76_6c322e07a4ce
///timestamp: char*
///title: char*
///message: char*
///location: char*
///user_data: void*
public delegate void _grn_logger_log(ref grn_ctx ctx, grn_log_level level, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string timestamp, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string title, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string message, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string location, System.IntPtr user_data);

/// Return Type: void
///ctx: grn_ctx*
///user_data: void*
public delegate void _grn_logger_reopen(ref grn_ctx ctx, System.IntPtr user_data);

/// Return Type: void
///ctx: grn_ctx*
///user_data: void*
public delegate void _grn_logger_fin(ref grn_ctx ctx, System.IntPtr user_data);

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_logger {
    
    /// grn_log_level->Anonymous_1ceaa881_6549_4381_9e76_6c322e07a4ce
    public grn_log_level max_level;
    
    /// int
    public int flags;
    
    /// void*
    public System.IntPtr user_data;
    
    /// _grn_logger_log
    public _grn_logger_log AnonymousMember1;
    
    /// _grn_logger_reopen
    public _grn_logger_reopen AnonymousMember2;
    
    /// _grn_logger_fin
    public _grn_logger_fin AnonymousMember3;
}

/// Return Type: void
///ctx: grn_ctx*
///flag: unsigned int
///timestamp: char*
///info: char*
///message: char*
///user_data: void*
public delegate void _grn_query_logger_log(ref grn_ctx ctx, uint flag, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string timestamp, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string info, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string message, System.IntPtr user_data);

/// Return Type: void
///ctx: grn_ctx*
///user_data: void*
public delegate void _grn_query_logger_reopen(ref grn_ctx ctx, System.IntPtr user_data);

/// Return Type: void
///ctx: grn_ctx*
///user_data: void*
public delegate void _grn_query_logger_fin(ref grn_ctx ctx, System.IntPtr user_data);

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_query_logger {
    
    /// unsigned int
    public uint flags;
    
    /// void*
    public System.IntPtr user_data;
    
    /// _grn_query_logger_log
    public _grn_query_logger_log AnonymousMember1;
    
    /// _grn_query_logger_reopen
    public _grn_query_logger_reopen AnonymousMember2;
    
    /// _grn_query_logger_fin
    public _grn_query_logger_fin AnonymousMember3;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_obj_format {
    
    /// grn_obj->_grn_obj
    public grn_table_cursor columns;
    
    /// void*
    public System.IntPtr min;
    
    /// void*
    public System.IntPtr max;
    
    /// unsigned int
    public uint min_size;
    
    /// unsigned int
    public uint max_size;
    
    /// int
    public int nhits;
    
    /// int
    public int offset;
    
    /// int
    public int limit;
    
    /// int
    public int hits_offset;
    
    /// int
    public int flags;
    
    /// grn_obj*
    public System.IntPtr expression;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_ctx_info {
    
    /// int
    public int fd;
    
    /// unsigned int
    public uint com_status;
    
    /// grn_obj*
    public System.IntPtr outbuf;
    
    /// unsigned char
    public byte stat;
}

/// Return Type: int
///ctx: grn_ctx*
///param1: grn_obj*
///param2: grn_id->unsigned int
///param3: void*
public delegate int _grn_table_delete_optarg_func(ref grn_ctx ctx, ref grn_table_cursor param1, uint param2, System.IntPtr param3);

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct _grn_table_delete_optarg {
    
    /// int
    public int flags;
    
    /// _grn_table_delete_optarg_func
    public _grn_table_delete_optarg_func AnonymousMember1;
    
    /// void*
    public System.IntPtr func_arg;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct _grn_pat_scan_hit {
    
    /// grn_id->unsigned int
    public uint id;
    
    /// unsigned int
    public uint offset;
    
    /// unsigned int
    public uint length;
}

[StructLayoutAttribute(LayoutKind.Explicit)]
public struct Anonymous_table_cursor_union {
    
    /// Anonymous_c605e26c_0860_4c6d_b847_a3950357afd8
    [FieldOffsetAttribute(0)]
	public Anonymous_struct_b b;
    
    /// Anonymous_4b2cc5f2_94a9_46d5_b5aa_e822e3b88c68
    [FieldOffsetAttribute(0)]
    public Anonymous_struct_v v;
}

/// Return Type: void
///param0: grn_ctx*
///param1: int
///param2: void*
public delegate void Anonymous_ctx_proc_func(ref grn_ctx param0, int param1, System.IntPtr param2);

public enum grn_command_version {
    
    /// GRN_COMMAND_VERSION_DEFAULT -> 0
    GRN_COMMAND_VERSION_DEFAULT = 0,
    
    GRN_COMMAND_VERSION_1,
    
    GRN_COMMAND_VERSION_2,
}

public enum grn_operator {
    
    /// GRN_OP_PUSH -> 0
    GRN_OP_PUSH = 0,
    
    GRN_OP_POP,
    
    GRN_OP_NOP,
    
    GRN_OP_CALL,
    
    GRN_OP_INTERN,
    
    GRN_OP_GET_REF,
    
    GRN_OP_GET_VALUE,
    
    GRN_OP_AND,
    
    GRN_OP_AND_NOT,
    
    GRN_OP_OR,
    
    GRN_OP_ASSIGN,
    
    GRN_OP_STAR_ASSIGN,
    
    GRN_OP_SLASH_ASSIGN,
    
    GRN_OP_MOD_ASSIGN,
    
    GRN_OP_PLUS_ASSIGN,
    
    GRN_OP_MINUS_ASSIGN,
    
    GRN_OP_SHIFTL_ASSIGN,
    
    GRN_OP_SHIFTR_ASSIGN,
    
    GRN_OP_SHIFTRR_ASSIGN,
    
    GRN_OP_AND_ASSIGN,
    
    GRN_OP_XOR_ASSIGN,
    
    GRN_OP_OR_ASSIGN,
    
    GRN_OP_JUMP,
    
    GRN_OP_CJUMP,
    
    GRN_OP_COMMA,
    
    GRN_OP_BITWISE_OR,
    
    GRN_OP_BITWISE_XOR,
    
    GRN_OP_BITWISE_AND,
    
    GRN_OP_BITWISE_NOT,
    
    GRN_OP_EQUAL,
    
    GRN_OP_NOT_EQUAL,
    
    GRN_OP_LESS,
    
    GRN_OP_GREATER,
    
    GRN_OP_LESS_EQUAL,
    
    GRN_OP_GREATER_EQUAL,
    
    GRN_OP_IN,
    
    GRN_OP_MATCH,
    
    GRN_OP_NEAR,
    
    GRN_OP_NEAR2,
    
    GRN_OP_SIMILAR,
    
    GRN_OP_TERM_EXTRACT,
    
    GRN_OP_SHIFTL,
    
    GRN_OP_SHIFTR,
    
    GRN_OP_SHIFTRR,
    
    GRN_OP_PLUS,
    
    GRN_OP_MINUS,
    
    GRN_OP_STAR,
    
    GRN_OP_SLASH,
    
    GRN_OP_MOD,
    
    GRN_OP_DELETE,
    
    GRN_OP_INCR,
    
    GRN_OP_DECR,
    
    GRN_OP_INCR_POST,
    
    GRN_OP_DECR_POST,
    
    GRN_OP_NOT,
    
    GRN_OP_ADJUST,
    
    GRN_OP_EXACT,
    
    GRN_OP_LCP,
    
    GRN_OP_PARTIAL,
    
    GRN_OP_UNSPLIT,
    
    GRN_OP_PREFIX,
    
    GRN_OP_SUFFIX,
    
    GRN_OP_GEO_DISTANCE1,
    
    GRN_OP_GEO_DISTANCE2,
    
    GRN_OP_GEO_DISTANCE3,
    
    GRN_OP_GEO_DISTANCE4,
    
    GRN_OP_GEO_WITHINP5,
    
    GRN_OP_GEO_WITHINP6,
    
    GRN_OP_GEO_WITHINP8,
    
    GRN_OP_OBJ_SEARCH,
    
    GRN_OP_EXPR_GET_VAR,
    
    GRN_OP_TABLE_CREATE,
    
    GRN_OP_TABLE_SELECT,
    
    GRN_OP_TABLE_SORT,
    
    GRN_OP_TABLE_GROUP,
    
    GRN_OP_JSON_PUT,
    
    GRN_OP_GET_MEMBER,
}

public enum grn_log_level {
    
    /// GRN_LOG_NONE -> 0
    GRN_LOG_NONE = 0,
    
    GRN_LOG_EMERG,
    
    GRN_LOG_ALERT,
    
    GRN_LOG_CRIT,
    
    GRN_LOG_ERROR,
    
    GRN_LOG_WARNING,
    
    GRN_LOG_NOTICE,
    
    GRN_LOG_INFO,
    
    GRN_LOG_DEBUG,
    
    GRN_LOG_DUMP,
}

public enum grn_rc {
    
    /// GRN_SUCCESS -> 0
    GRN_SUCCESS = 0,
    
    /// GRN_END_OF_DATA -> 1
    GRN_END_OF_DATA = 1,
    
    /// GRN_UNKNOWN_ERROR -> -1
    GRN_UNKNOWN_ERROR = -1,
    
    /// GRN_OPERATION_NOT_PERMITTED -> -2
    GRN_OPERATION_NOT_PERMITTED = -2,
    
    /// GRN_NO_SUCH_FILE_OR_DIRECTORY -> -3
    GRN_NO_SUCH_FILE_OR_DIRECTORY = -3,
    
    /// GRN_NO_SUCH_PROCESS -> -4
    GRN_NO_SUCH_PROCESS = -4,
    
    /// GRN_INTERRUPTED_FUNCTION_CALL -> -5
    GRN_INTERRUPTED_FUNCTION_CALL = -5,
    
    /// GRN_INPUT_OUTPUT_ERROR -> -6
    GRN_INPUT_OUTPUT_ERROR = -6,
    
    /// GRN_NO_SUCH_DEVICE_OR_ADDRESS -> -7
    GRN_NO_SUCH_DEVICE_OR_ADDRESS = -7,
    
    /// GRN_ARG_LIST_TOO_LONG -> -8
    GRN_ARG_LIST_TOO_LONG = -8,
    
    /// GRN_EXEC_FORMAT_ERROR -> -9
    GRN_EXEC_FORMAT_ERROR = -9,
    
    /// GRN_BAD_FILE_DESCRIPTOR -> -10
    GRN_BAD_FILE_DESCRIPTOR = -10,
    
    /// GRN_NO_CHILD_PROCESSES -> -11
    GRN_NO_CHILD_PROCESSES = -11,
    
    /// GRN_RESOURCE_TEMPORARILY_UNAVAILABLE -> -12
    GRN_RESOURCE_TEMPORARILY_UNAVAILABLE = -12,
    
    /// GRN_NOT_ENOUGH_SPACE -> -13
    GRN_NOT_ENOUGH_SPACE = -13,
    
    /// GRN_PERMISSION_DENIED -> -14
    GRN_PERMISSION_DENIED = -14,
    
    /// GRN_BAD_ADDRESS -> -15
    GRN_BAD_ADDRESS = -15,
    
    /// GRN_RESOURCE_BUSY -> -16
    GRN_RESOURCE_BUSY = -16,
    
    /// GRN_FILE_EXISTS -> -17
    GRN_FILE_EXISTS = -17,
    
    /// GRN_IMPROPER_LINK -> -18
    GRN_IMPROPER_LINK = -18,
    
    /// GRN_NO_SUCH_DEVICE -> -19
    GRN_NO_SUCH_DEVICE = -19,
    
    /// GRN_NOT_A_DIRECTORY -> -20
    GRN_NOT_A_DIRECTORY = -20,
    
    /// GRN_IS_A_DIRECTORY -> -21
    GRN_IS_A_DIRECTORY = -21,
    
    /// GRN_INVALID_ARGUMENT -> -22
    GRN_INVALID_ARGUMENT = -22,
    
    /// GRN_TOO_MANY_OPEN_FILES_IN_SYSTEM -> -23
    GRN_TOO_MANY_OPEN_FILES_IN_SYSTEM = -23,
    
    /// GRN_TOO_MANY_OPEN_FILES -> -24
    GRN_TOO_MANY_OPEN_FILES = -24,
    
    /// GRN_INAPPROPRIATE_I_O_CONTROL_OPERATION -> -25
    GRN_INAPPROPRIATE_I_O_CONTROL_OPERATION = -25,
    
    /// GRN_FILE_TOO_LARGE -> -26
    GRN_FILE_TOO_LARGE = -26,
    
    /// GRN_NO_SPACE_LEFT_ON_DEVICE -> -27
    GRN_NO_SPACE_LEFT_ON_DEVICE = -27,
    
    /// GRN_INVALID_SEEK -> -28
    GRN_INVALID_SEEK = -28,
    
    /// GRN_READ_ONLY_FILE_SYSTEM -> -29
    GRN_READ_ONLY_FILE_SYSTEM = -29,
    
    /// GRN_TOO_MANY_LINKS -> -30
    GRN_TOO_MANY_LINKS = -30,
    
    /// GRN_BROKEN_PIPE -> -31
    GRN_BROKEN_PIPE = -31,
    
    /// GRN_DOMAIN_ERROR -> -32
    GRN_DOMAIN_ERROR = -32,
    
    /// GRN_RESULT_TOO_LARGE -> -33
    GRN_RESULT_TOO_LARGE = -33,
    
    /// GRN_RESOURCE_DEADLOCK_AVOIDED -> -34
    GRN_RESOURCE_DEADLOCK_AVOIDED = -34,
    
    /// GRN_NO_MEMORY_AVAILABLE -> -35
    GRN_NO_MEMORY_AVAILABLE = -35,
    
    /// GRN_FILENAME_TOO_LONG -> -36
    GRN_FILENAME_TOO_LONG = -36,
    
    /// GRN_NO_LOCKS_AVAILABLE -> -37
    GRN_NO_LOCKS_AVAILABLE = -37,
    
    /// GRN_FUNCTION_NOT_IMPLEMENTED -> -38
    GRN_FUNCTION_NOT_IMPLEMENTED = -38,
    
    /// GRN_DIRECTORY_NOT_EMPTY -> -39
    GRN_DIRECTORY_NOT_EMPTY = -39,
    
    /// GRN_ILLEGAL_BYTE_SEQUENCE -> -40
    GRN_ILLEGAL_BYTE_SEQUENCE = -40,
    
    /// GRN_SOCKET_NOT_INITIALIZED -> -41
    GRN_SOCKET_NOT_INITIALIZED = -41,
    
    /// GRN_OPERATION_WOULD_BLOCK -> -42
    GRN_OPERATION_WOULD_BLOCK = -42,
    
    /// GRN_ADDRESS_IS_NOT_AVAILABLE -> -43
    GRN_ADDRESS_IS_NOT_AVAILABLE = -43,
    
    /// GRN_NETWORK_IS_DOWN -> -44
    GRN_NETWORK_IS_DOWN = -44,
    
    /// GRN_NO_BUFFER -> -45
    GRN_NO_BUFFER = -45,
    
    /// GRN_SOCKET_IS_ALREADY_CONNECTED -> -46
    GRN_SOCKET_IS_ALREADY_CONNECTED = -46,
    
    /// GRN_SOCKET_IS_NOT_CONNECTED -> -47
    GRN_SOCKET_IS_NOT_CONNECTED = -47,
    
    /// GRN_SOCKET_IS_ALREADY_SHUTDOWNED -> -48
    GRN_SOCKET_IS_ALREADY_SHUTDOWNED = -48,
    
    /// GRN_OPERATION_TIMEOUT -> -49
    GRN_OPERATION_TIMEOUT = -49,
    
    /// GRN_CONNECTION_REFUSED -> -50
    GRN_CONNECTION_REFUSED = -50,
    
    /// GRN_RANGE_ERROR -> -51
    GRN_RANGE_ERROR = -51,
    
    /// GRN_TOKENIZER_ERROR -> -52
    GRN_TOKENIZER_ERROR = -52,
    
    /// GRN_FILE_CORRUPT -> -53
    GRN_FILE_CORRUPT = -53,
    
    /// GRN_INVALID_FORMAT -> -54
    GRN_INVALID_FORMAT = -54,
    
    /// GRN_OBJECT_CORRUPT -> -55
    GRN_OBJECT_CORRUPT = -55,
    
    /// GRN_TOO_MANY_SYMBOLIC_LINKS -> -56
    GRN_TOO_MANY_SYMBOLIC_LINKS = -56,
    
    /// GRN_NOT_SOCKET -> -57
    GRN_NOT_SOCKET = -57,
    
    /// GRN_OPERATION_NOT_SUPPORTED -> -58
    GRN_OPERATION_NOT_SUPPORTED = -58,
    
    /// GRN_ADDRESS_IS_IN_USE -> -59
    GRN_ADDRESS_IS_IN_USE = -59,
    
    /// GRN_ZLIB_ERROR -> -60
    GRN_ZLIB_ERROR = -60,
    
    /// GRN_LZO_ERROR -> -61
    GRN_LZO_ERROR = -61,
    
    /// GRN_STACK_OVER_FLOW -> -62
    GRN_STACK_OVER_FLOW = -62,
    
    /// GRN_SYNTAX_ERROR -> -63
    GRN_SYNTAX_ERROR = -63,
    
    /// GRN_RETRY_MAX -> -64
    GRN_RETRY_MAX = -64,
    
    /// GRN_INCOMPATIBLE_FILE_FORMAT -> -65
    GRN_INCOMPATIBLE_FILE_FORMAT = -65,
    
    /// GRN_UPDATE_NOT_ALLOWED -> -66
    GRN_UPDATE_NOT_ALLOWED = -66,
    
    /// GRN_TOO_SMALL_OFFSET -> -67
    GRN_TOO_SMALL_OFFSET = -67,
    
    /// GRN_TOO_LARGE_OFFSET -> -68
    GRN_TOO_LARGE_OFFSET = -68,
    
    /// GRN_TOO_SMALL_LIMIT -> -69
    GRN_TOO_SMALL_LIMIT = -69,
    
    /// GRN_CAS_ERROR -> -70
    GRN_CAS_ERROR = -70,
    
    /// GRN_UNSUPPORTED_COMMAND_VERSION -> -71
    GRN_UNSUPPORTED_COMMAND_VERSION = -71,
    
    /// GRN_NORMALIZER_ERROR -> -72
    GRN_NORMALIZER_ERROR = -72,
}

public enum grn_encoding {
    
    /// GRN_ENC_DEFAULT -> 0
    GRN_ENC_DEFAULT = 0,
    
    GRN_ENC_NONE,
    
    GRN_ENC_EUC_JP,
    
    GRN_ENC_UTF8,
    
    GRN_ENC_SJIS,
    
    GRN_ENC_LATIN1,
    
    GRN_ENC_KOI8R,
}

[StructLayoutAttribute(LayoutKind.Explicit)]
public struct grn_user_data {
    
    /// int
    [FieldOffsetAttribute(0)]
    public int int_value;
    
    /// grn_id->unsigned int
    [FieldOffsetAttribute(0)]
    public uint id;
    
    /// void*
    [FieldOffsetAttribute(0)]
    public System.IntPtr ptr;
}

public enum grn_proc_type {
    
    /// GRN_PROC_INVALID -> 0
    GRN_PROC_INVALID = 0,
    
    GRN_PROC_TOKENIZER,
    
    GRN_PROC_COMMAND,
    
    GRN_PROC_FUNCTION,
    
    GRN_PROC_HOOK,
    
    GRN_PROC_NORMALIZER,
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_posting {
    
    /// grn_id->unsigned int
    public uint rid;
    
    /// grn_id->unsigned int
    public uint sid;
    
    /// unsigned int
    public uint pos;
    
    /// unsigned int
    public uint tf;
    
    /// unsigned int
    public uint weight;
    
    /// unsigned int
    public uint rest;
}

public enum grn_info_type {
    
    /// GRN_INFO_ENCODING -> 0
    GRN_INFO_ENCODING = 0,
    
    GRN_INFO_SOURCE,
    
    GRN_INFO_DEFAULT_TOKENIZER,
    
    GRN_INFO_ELEMENT_SIZE,
    
    GRN_INFO_CURR_MAX,
    
    GRN_INFO_MAX_ELEMENT_SIZE,
    
    GRN_INFO_SEG_SIZE,
    
    GRN_INFO_CHUNK_SIZE,
    
    GRN_INFO_MAX_SECTION,
    
    GRN_INFO_HOOK_LOCAL_DATA,
    
    GRN_INFO_ELEMENT_A,
    
    GRN_INFO_ELEMENT_CHUNK,
    
    GRN_INFO_ELEMENT_CHUNK_SIZE,
    
    GRN_INFO_ELEMENT_BUFFER_FREE,
    
    GRN_INFO_ELEMENT_NTERMS,
    
    GRN_INFO_ELEMENT_NTERMS_VOID,
    
    GRN_INFO_ELEMENT_SIZE_IN_CHUNK,
    
    GRN_INFO_ELEMENT_POS_IN_CHUNK,
    
    GRN_INFO_ELEMENT_SIZE_IN_BUFFER,
    
    GRN_INFO_ELEMENT_POS_IN_BUFFER,
    
    GRN_INFO_ELEMENT_ESTIMATE_SIZE,
    
    GRN_INFO_NGRAM_UNIT_SIZE,
    
    GRN_INFO_PARTIAL_MATCH_THRESHOLD,
    
    GRN_INFO_II_SPLIT_THRESHOLD,
    
    GRN_INFO_SUPPORT_ZLIB,
    
    GRN_INFO_SUPPORT_LZO,
    
    GRN_INFO_NORMALIZER,
}

public enum grn_hook_entry {
    
    /// GRN_HOOK_SET -> 0
    GRN_HOOK_SET = 0,
    
    GRN_HOOK_GET,
    
    GRN_HOOK_INSERT,
    
    GRN_HOOK_DELETE,
    
    GRN_HOOK_SELECT,
}

public enum grn_content_type {
    
    /// GRN_CONTENT_NONE -> 0
    GRN_CONTENT_NONE = 0,
    
    GRN_CONTENT_TSV,
    
    GRN_CONTENT_JSON,
    
    GRN_CONTENT_XML,
    
    GRN_CONTENT_MSGPACK,
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_str {
    
    /// char*
    [MarshalAsAttribute(UnmanagedType.LPStr)]
    public string orig;
    
    /// char*
    [MarshalAsAttribute(UnmanagedType.LPStr)]
    public string norm;
    
    /// short*
    public System.IntPtr checks;
    
    /// unsigned char*
    [MarshalAsAttribute(UnmanagedType.LPStr)]
    public string ctypes;
    
    /// int
    public int flags;
    
    /// unsigned int
    public uint orig_blen;
    
    /// unsigned int
    public uint norm_blen;
    
    /// unsigned int
    public uint length;
    
    /// grn_encoding->Anonymous_4cc9cdbc_7025_4e0d_86b2_46372051bb24
    public grn_encoding encoding;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct grn_expr_var {
    
    /// char*
    [MarshalAsAttribute(UnmanagedType.LPStr)]
    public string name;
    
    /// unsigned int
    public uint name_size;
    
    /// grn_obj->_grn_obj
    public grn_table_cursor value;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct Anonymous_struct_b {
    
    /// char*
    [MarshalAsAttribute(UnmanagedType.LPStr)]
    public string head;
    
    /// char*
    [MarshalAsAttribute(UnmanagedType.LPStr)]
    public string curr;
    
    /// char*
    [MarshalAsAttribute(UnmanagedType.LPStr)]
    public string tail;
}

[StructLayoutAttribute(LayoutKind.Sequential)]
public struct Anonymous_struct_v {
    
    /// grn_obj*
    public System.IntPtr body;
    
    /// grn_section*
    public System.IntPtr sections;
    
    /// int
    public int n_sections;
}

public partial class NativeMethods {
    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    [DllImportAttribute("groonga.dll", EntryPoint="grn_init")]
public static extern  grn_rc grn_init() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    [DllImportAttribute("groonga.dll", EntryPoint="grn_fin")]
public static extern  grn_rc grn_fin() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_init")]
public static extern  grn_rc grn_ctx_init(ref grn_ctx ctx, int flags) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_fin")]
public static extern  grn_rc grn_ctx_fin(ref grn_ctx ctx) ;

    
    /// Return Type: grn_ctx*
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_open")]
public static extern  System.IntPtr grn_ctx_open(int flags) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_close")]
public static extern  grn_rc grn_ctx_close(ref grn_ctx ctx) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///func: grn_proc_func*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_set_finalizer")]
public static extern  grn_rc grn_ctx_set_finalizer(ref grn_ctx ctx, ref grn_proc_func func) ;

    
    /// Return Type: grn_encoding->Anonymous_4cc9cdbc_7025_4e0d_86b2_46372051bb24
    [DllImportAttribute("groonga.dll", EntryPoint="grn_get_default_encoding")]
public static extern  grn_encoding grn_get_default_encoding() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///encoding: grn_encoding->Anonymous_4cc9cdbc_7025_4e0d_86b2_46372051bb24
    [DllImportAttribute("groonga.dll", EntryPoint="grn_set_default_encoding")]
public static extern  grn_rc grn_set_default_encoding(grn_encoding encoding) ;

    
    /// Return Type: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_get_version")]
public static extern  System.IntPtr grn_get_version() ;

    
    /// Return Type: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_get_package")]
public static extern  System.IntPtr grn_get_package() ;

    
    /// Return Type: grn_command_version->Anonymous_0e1d1b04_972f_4266_9c81_efb77a82e13d
    [DllImportAttribute("groonga.dll", EntryPoint="grn_get_default_command_version")]
public static extern  grn_command_version grn_get_default_command_version() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///version: grn_command_version->Anonymous_0e1d1b04_972f_4266_9c81_efb77a82e13d
    [DllImportAttribute("groonga.dll", EntryPoint="grn_set_default_command_version")]
public static extern  grn_rc grn_set_default_command_version(grn_command_version version) ;

    
    /// Return Type: grn_command_version->Anonymous_0e1d1b04_972f_4266_9c81_efb77a82e13d
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_get_command_version")]
public static extern  grn_command_version grn_ctx_get_command_version(ref grn_ctx ctx) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///version: grn_command_version->Anonymous_0e1d1b04_972f_4266_9c81_efb77a82e13d
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_set_command_version")]
public static extern  grn_rc grn_ctx_set_command_version(ref grn_ctx ctx, grn_command_version version) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_get_match_escalation_threshold")]
public static extern  int grn_ctx_get_match_escalation_threshold(ref grn_ctx ctx) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///param1: int
    ///threshold: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_set_match_escalation_threshold")]
public static extern  grn_rc grn_ctx_set_match_escalation_threshold(ref grn_ctx ctx, int param1, int threshold) ;

    
    /// Return Type: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_get_default_match_escalation_threshold")]
public static extern  int grn_get_default_match_escalation_threshold() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///param0: int
    ///threshold: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_set_default_match_escalation_threshold")]
public static extern  grn_rc grn_set_default_match_escalation_threshold(int param0, int threshold) ;

    
    /// Return Type: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_get_lock_timeout")]
public static extern  int grn_get_lock_timeout() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///timeout: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_set_lock_timeout")]
public static extern  grn_rc grn_set_lock_timeout(int timeout) ;

    
    /// Return Type: char*
    ///encoding: grn_encoding->Anonymous_4cc9cdbc_7025_4e0d_86b2_46372051bb24
    [DllImportAttribute("groonga.dll", EntryPoint="grn_encoding_to_string")]
public static extern  System.IntPtr grn_encoding_to_string(grn_encoding encoding) ;

    
    /// Return Type: grn_encoding->Anonymous_4cc9cdbc_7025_4e0d_86b2_46372051bb24
    ///name: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_encoding_parse")]
public static extern  grn_encoding grn_encoding_parse([InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///path: char*
    ///optarg: grn_db_create_optarg*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_db_create")]
public static extern  System.IntPtr grn_db_create(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path, ref grn_db_create_optarg optarg) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///path: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_db_open")]
public static extern  System.IntPtr grn_db_open(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///db: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_db_touch")]
public static extern  void grn_db_touch(ref grn_ctx ctx, ref grn_table_cursor db) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///db: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_use")]
public static extern  grn_rc grn_ctx_use(ref grn_ctx ctx, ref grn_table_cursor db) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_db")]
public static extern  System.IntPtr grn_ctx_db(ref grn_ctx ctx) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///name: char*
    ///name_size: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_get")]
public static extern  System.IntPtr grn_ctx_get(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, int name_size) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///id: grn_id->unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_at")]
public static extern  System.IntPtr grn_ctx_at(ref grn_ctx ctx, uint id) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///name: char*
    ///name_size: unsigned int
    ///flags: grn_obj_flags->unsigned short
    ///size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_type_create")]
public static extern  System.IntPtr grn_type_create(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size, ushort flags, uint size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///name: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_plugin_register")]
public static extern  grn_rc grn_plugin_register(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///path: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_plugin_register_by_path")]
public static extern  grn_rc grn_plugin_register_by_path(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path) ;

    
    /// Return Type: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_plugin_get_system_plugins_dir")]
public static extern  System.IntPtr grn_plugin_get_system_plugins_dir() ;

    
    /// Return Type: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_plugin_get_suffix")]
public static extern  System.IntPtr grn_plugin_get_suffix() ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///name: char*
    ///name_size: int
    ///type: grn_proc_type->Anonymous_d6ebf05a_1f0a_4ff9_9e65_87ade8bc3d73
    ///init: grn_proc_func*
    ///next: grn_proc_func*
    ///fin: grn_proc_func*
    ///nvars: unsigned int
    ///vars: grn_expr_var*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_proc_create")]
public static extern  System.IntPtr grn_proc_create(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, int name_size, grn_proc_type type, ref grn_proc_func init, ref grn_proc_func next, ref grn_proc_func fin, uint nvars, ref grn_expr_var vars) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///user_data: grn_user_data*
    ///vars: grn_expr_var**
    ///nvars: unsigned int*
    ///caller: grn_obj**
    [DllImportAttribute("groonga.dll", EntryPoint="grn_proc_get_info")]
public static extern  System.IntPtr grn_proc_get_info(ref grn_ctx ctx, ref grn_user_data user_data, ref System.IntPtr vars, ref uint nvars, ref System.IntPtr caller) ;

    
    /// Return Type: grn_proc_type->Anonymous_d6ebf05a_1f0a_4ff9_9e65_87ade8bc3d73
    ///ctx: grn_ctx*
    ///proc: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_proc_get_type")]
public static extern  grn_proc_type grn_proc_get_type(ref grn_ctx ctx, ref grn_table_cursor proc) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///name: char*
    ///name_size: unsigned int
    ///path: char*
    ///flags: grn_obj_flags->unsigned short
    ///key_type: grn_obj*
    ///value_type: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_create")]
public static extern  System.IntPtr grn_table_create(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path, ushort flags, ref grn_table_cursor key_type, ref grn_table_cursor value_type) ;

    
    /// Return Type: grn_id->unsigned int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///key: void*
    ///key_size: unsigned int
    ///added: int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_add")]
public static extern  uint grn_table_add(ref grn_ctx ctx, ref grn_table_cursor table, System.IntPtr key, uint key_size, ref int added) ;

    
    /// Return Type: grn_id->unsigned int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///key: void*
    ///key_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_get")]
public static extern  uint grn_table_get(ref grn_ctx ctx, ref grn_table_cursor table, System.IntPtr key, uint key_size) ;

    
    /// Return Type: grn_id->unsigned int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///id: grn_id->unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_at")]
public static extern  uint grn_table_at(ref grn_ctx ctx, ref grn_table_cursor table, uint id) ;

    
    /// Return Type: grn_id->unsigned int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///key: void*
    ///key_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_lcp_search")]
public static extern  uint grn_table_lcp_search(ref grn_ctx ctx, ref grn_table_cursor table, System.IntPtr key, uint key_size) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///id: grn_id->unsigned int
    ///keybuf: void*
    ///buf_size: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_get_key")]
public static extern  int grn_table_get_key(ref grn_ctx ctx, ref grn_table_cursor table, uint id, System.IntPtr keybuf, int buf_size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///key: void*
    ///key_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_delete")]
public static extern  grn_rc grn_table_delete(ref grn_ctx ctx, ref grn_table_cursor table, System.IntPtr key, uint key_size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///id: grn_id->unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_delete_by_id")]
public static extern  grn_rc grn_table_delete_by_id(ref grn_ctx ctx, ref grn_table_cursor table, uint id) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///id: grn_id->unsigned int
    ///dest_key: void*
    ///dest_key_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_update_by_id")]
public static extern  grn_rc grn_table_update_by_id(ref grn_ctx ctx, ref grn_table_cursor table, uint id, System.IntPtr dest_key, uint dest_key_size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///src_key: void*
    ///src_key_size: unsigned int
    ///dest_key: void*
    ///dest_key_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_update")]
public static extern  grn_rc grn_table_update(ref grn_ctx ctx, ref grn_table_cursor table, System.IntPtr src_key, uint src_key_size, System.IntPtr dest_key, uint dest_key_size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///table: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_truncate")]
public static extern  grn_rc grn_table_truncate(ref grn_ctx ctx, ref grn_table_cursor table) ;

    
    /// Return Type: grn_table_cursor*
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///min: void*
    ///min_size: unsigned int
    ///max: void*
    ///max_size: unsigned int
    ///offset: int
    ///limit: int
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_cursor_open")]
public static extern  System.IntPtr grn_table_cursor_open(ref grn_ctx ctx, ref grn_table_cursor table, System.IntPtr min, uint min_size, System.IntPtr max, uint max_size, int offset, int limit, int flags) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///tc: grn_table_cursor*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_cursor_close")]
public static extern  grn_rc grn_table_cursor_close(ref grn_ctx ctx, ref grn_table_cursor tc) ;

    
    /// Return Type: grn_id->unsigned int
    ///ctx: grn_ctx*
    ///tc: grn_table_cursor*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_cursor_next")]
public static extern  uint grn_table_cursor_next(ref grn_ctx ctx, ref grn_table_cursor tc) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///tc: grn_table_cursor*
    ///key: void**
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_cursor_get_key")]
public static extern  int grn_table_cursor_get_key(ref grn_ctx ctx, ref grn_table_cursor tc, ref System.IntPtr key) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///tc: grn_table_cursor*
    ///value: void**
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_cursor_get_value")]
public static extern  int grn_table_cursor_get_value(ref grn_ctx ctx, ref grn_table_cursor tc, ref System.IntPtr value) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///tc: grn_table_cursor*
    ///value: void*
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_cursor_set_value")]
public static extern  grn_rc grn_table_cursor_set_value(ref grn_ctx ctx, ref grn_table_cursor tc, System.IntPtr value, int flags) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///tc: grn_table_cursor*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_cursor_delete")]
public static extern  grn_rc grn_table_cursor_delete(ref grn_ctx ctx, ref grn_table_cursor tc) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///tc: grn_table_cursor*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_cursor_table")]
public static extern  System.IntPtr grn_table_cursor_table(ref grn_ctx ctx, ref grn_table_cursor tc) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///tc: grn_table_cursor*
    ///index: grn_obj*
    ///rid_min: grn_id->unsigned int
    ///rid_max: grn_id->unsigned int
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_index_cursor_open")]
public static extern  System.IntPtr grn_index_cursor_open(ref grn_ctx ctx, ref grn_table_cursor tc, ref grn_table_cursor index, uint rid_min, uint rid_max, int flags) ;

    
    /// Return Type: grn_posting*
    ///ctx: grn_ctx*
    ///ic: grn_obj*
    ///tid: grn_id*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_index_cursor_next")]
public static extern  System.IntPtr grn_index_cursor_next(ref grn_ctx ctx, ref grn_table_cursor ic, ref uint tid) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///offset: int
    ///limit: int
    ///result: grn_obj*
    ///keys: grn_table_sort_key*
    ///n_keys: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_sort")]
public static extern  int grn_table_sort(ref grn_ctx ctx, ref grn_table_cursor table, int offset, int limit, ref grn_table_cursor result, ref grn_table_sort_key keys, int n_keys) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///keys: grn_table_sort_key*
    ///n_keys: int
    ///results: grn_table_group_result*
    ///n_results: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_group")]
public static extern  grn_rc grn_table_group(ref grn_ctx ctx, ref grn_table_cursor table, ref grn_table_sort_key keys, int n_keys, ref grn_table_group_result results, int n_results) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///table1: grn_obj*
    ///table2: grn_obj*
    ///res: grn_obj*
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_setoperation")]
public static extern  grn_rc grn_table_setoperation(ref grn_ctx ctx, ref grn_table_cursor table1, ref grn_table_cursor table2, ref grn_table_cursor res, grn_operator op) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///table1: grn_obj*
    ///table2: grn_obj*
    ///res1: grn_obj*
    ///res2: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_difference")]
public static extern  grn_rc grn_table_difference(ref grn_ctx ctx, ref grn_table_cursor table1, ref grn_table_cursor table2, ref grn_table_cursor res1, ref grn_table_cursor res2) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///name: char*
    ///name_size: unsigned int
    ///res: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_columns")]
public static extern  int grn_table_columns(ref grn_ctx ctx, ref grn_table_cursor table, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size, ref grn_table_cursor res) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///name: char*
    ///name_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_column")]
public static extern  System.IntPtr grn_obj_column(ref grn_ctx ctx, ref grn_table_cursor table, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size) ;

    
    /// Return Type: unsigned int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_size")]
public static extern  uint grn_table_size(ref grn_ctx ctx, ref grn_table_cursor table) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///name: char*
    ///name_size: unsigned int
    ///path: char*
    ///flags: grn_obj_flags->unsigned short
    ///type: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_column_create")]
public static extern  System.IntPtr grn_column_create(ref grn_ctx ctx, ref grn_table_cursor table, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path, ushort flags, ref grn_table_cursor type) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///column: grn_obj*
    ///id: grn_id->unsigned int
    ///section: unsigned int
    ///oldvalue: grn_obj*
    ///newvalue: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_column_index_update")]
public static extern  grn_rc grn_column_index_update(ref grn_ctx ctx, ref grn_table_cursor column, uint id, uint section, ref grn_table_cursor oldvalue, ref grn_table_cursor newvalue) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///column: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_column_table")]
public static extern  System.IntPtr grn_column_table(ref grn_ctx ctx, ref grn_table_cursor column) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///type: grn_info_type->Anonymous_b5a29555_0744_43e3_9851_2c7c40476d92
    ///valuebuf: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_get_info")]
public static extern  System.IntPtr grn_obj_get_info(ref grn_ctx ctx, ref grn_table_cursor obj, grn_info_type type, ref grn_table_cursor valuebuf) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///type: grn_info_type->Anonymous_b5a29555_0744_43e3_9851_2c7c40476d92
    ///value: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_set_info")]
public static extern  grn_rc grn_obj_set_info(ref grn_ctx ctx, ref grn_table_cursor obj, grn_info_type type, ref grn_table_cursor value) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///id: grn_id->unsigned int
    ///type: grn_info_type->Anonymous_b5a29555_0744_43e3_9851_2c7c40476d92
    ///value: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_get_element_info")]
public static extern  System.IntPtr grn_obj_get_element_info(ref grn_ctx ctx, ref grn_table_cursor obj, uint id, grn_info_type type, ref grn_table_cursor value) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///id: grn_id->unsigned int
    ///type: grn_info_type->Anonymous_b5a29555_0744_43e3_9851_2c7c40476d92
    ///value: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_set_element_info")]
public static extern  grn_rc grn_obj_set_element_info(ref grn_ctx ctx, ref grn_table_cursor obj, uint id, grn_info_type type, ref grn_table_cursor value) ;

    
    /// Return Type: grn_bool->unsigned char
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_is_builtin")]
public static extern  byte grn_obj_is_builtin(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///id: grn_id->unsigned int
    ///value: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_get_value")]
public static extern  System.IntPtr grn_obj_get_value(ref grn_ctx ctx, ref grn_table_cursor obj, uint id, ref grn_table_cursor value) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///offset: grn_id->unsigned int
    ///values: void**
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_get_values")]
public static extern  int grn_obj_get_values(ref grn_ctx ctx, ref grn_table_cursor obj, uint offset, ref System.IntPtr values) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///id: grn_id->unsigned int
    ///value: grn_obj*
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_set_value")]
public static extern  grn_rc grn_obj_set_value(ref grn_ctx ctx, ref grn_table_cursor obj, uint id, ref grn_table_cursor value, int flags) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_remove")]
public static extern  grn_rc grn_obj_remove(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///name: char*
    ///name_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_rename")]
public static extern  grn_rc grn_obj_rename(ref grn_ctx ctx, ref grn_table_cursor obj, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///name: char*
    ///name_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_rename")]
public static extern  grn_rc grn_table_rename(ref grn_ctx ctx, ref grn_table_cursor table, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///column: grn_obj*
    ///name: char*
    ///name_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_column_rename")]
public static extern  grn_rc grn_column_rename(ref grn_ctx ctx, ref grn_table_cursor column, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_close")]
public static extern  grn_rc grn_obj_close(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///domain: grn_id->unsigned int
    ///flags: unsigned char
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_reinit")]
public static extern  grn_rc grn_obj_reinit(ref grn_ctx ctx, ref grn_table_cursor obj, uint domain, byte flags) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_unlink")]
public static extern  void grn_obj_unlink(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_user_data*
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_user_data")]
public static extern  System.IntPtr grn_obj_user_data(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///func: grn_proc_func*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_set_finalizer")]
public static extern  grn_rc grn_obj_set_finalizer(ref grn_ctx ctx, ref grn_table_cursor obj, ref grn_proc_func func) ;

    
    /// Return Type: char*
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_path")]
public static extern  System.IntPtr grn_obj_path(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///namebuf: char*
    ///buf_size: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_name")]
public static extern  int grn_obj_name(ref grn_ctx ctx, ref grn_table_cursor obj, System.IntPtr namebuf, int buf_size) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///namebuf: char*
    ///buf_size: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_column_name")]
public static extern  int grn_column_name(ref grn_ctx ctx, ref grn_table_cursor obj, System.IntPtr namebuf, int buf_size) ;

    
    /// Return Type: grn_id->unsigned int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_get_range")]
public static extern  uint grn_obj_get_range(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///threshold: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_expire")]
public static extern  int grn_obj_expire(ref grn_ctx ctx, ref grn_table_cursor obj, int threshold) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_check")]
public static extern  int grn_obj_check(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///id: grn_id->unsigned int
    ///timeout: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_lock")]
public static extern  grn_rc grn_obj_lock(ref grn_ctx ctx, ref grn_table_cursor obj, uint id, int timeout) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///id: grn_id->unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_unlock")]
public static extern  grn_rc grn_obj_unlock(ref grn_ctx ctx, ref grn_table_cursor obj, uint id) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_clear_lock")]
public static extern  grn_rc grn_obj_clear_lock(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: unsigned int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_is_locked")]
public static extern  uint grn_obj_is_locked(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///threshold: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_defrag")]
public static extern  int grn_obj_defrag(ref grn_ctx ctx, ref grn_table_cursor obj, int threshold) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_db")]
public static extern  System.IntPtr grn_obj_db(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_id->unsigned int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_id")]
public static extern  uint grn_obj_id(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///query: grn_obj*
    ///res: grn_obj*
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    ///optarg: grn_search_optarg*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_search")]
public static extern  grn_rc grn_obj_search(ref grn_ctx ctx, ref grn_table_cursor obj, ref grn_table_cursor query, ref grn_table_cursor res, grn_operator op, ref grn_search_optarg optarg) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///proc: grn_obj*
    ///selector: grn_selector_func
    [DllImportAttribute("groonga.dll", EntryPoint="grn_proc_set_selector")]
public static extern  grn_rc grn_proc_set_selector(ref grn_ctx ctx, ref grn_table_cursor proc, grn_selector_func selector) ;

    
    /// Return Type: unsigned int
    ///ctx: grn_ctx*
    ///vector: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_vector_size")]
public static extern  uint grn_vector_size(ref grn_ctx ctx, ref grn_table_cursor vector) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///vector: grn_obj*
    ///str: char*
    ///str_len: unsigned int
    ///weight: unsigned int
    ///domain: grn_id->unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_vector_add_element")]
public static extern  grn_rc grn_vector_add_element(ref grn_ctx ctx, ref grn_table_cursor vector, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint str_len, uint weight, uint domain) ;

    
    /// Return Type: unsigned int
    ///ctx: grn_ctx*
    ///vector: grn_obj*
    ///offset: unsigned int
    ///str: char**
    ///weight: unsigned int*
    ///domain: grn_id*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_vector_get_element")]
public static extern  uint grn_vector_get_element(ref grn_ctx ctx, ref grn_table_cursor vector, uint offset, ref System.IntPtr str, ref uint weight, ref uint domain) ;

    
    /// Return Type: unsigned int
    ///ctx: grn_ctx*
    ///uvector: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_uvector_size")]
public static extern  uint grn_uvector_size(ref grn_ctx ctx, ref grn_table_cursor uvector) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///vector: grn_obj*
    ///id: grn_id->unsigned int
    ///weight: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_uvector_add_element")]
public static extern  grn_rc grn_uvector_add_element(ref grn_ctx ctx, ref grn_table_cursor vector, uint id, uint weight) ;

    
    /// Return Type: grn_id->unsigned int
    ///ctx: grn_ctx*
    ///uvector: grn_obj*
    ///offset: unsigned int
    ///weight: unsigned int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_uvector_get_element")]
public static extern  uint grn_uvector_get_element(ref grn_ctx ctx, ref grn_table_cursor uvector, uint offset, ref uint weight) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///exec_info: grn_obj*
    ///in: grn_obj*
    ///out: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_proc_call_next")]
public static extern  int grn_proc_call_next(ref grn_ctx ctx, ref grn_table_cursor exec_info, ref grn_table_cursor @in, ref grn_table_cursor @out) ;

    
    /// Return Type: void*
    ///ctx: grn_ctx*
    ///exec_info: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_proc_get_ctx_local_data")]
public static extern  System.IntPtr grn_proc_get_ctx_local_data(ref grn_ctx ctx, ref grn_table_cursor exec_info) ;

    
    /// Return Type: void*
    ///ctx: grn_ctx*
    ///exec_info: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_proc_get_hook_local_data")]
public static extern  System.IntPtr grn_proc_get_hook_local_data(ref grn_ctx ctx, ref grn_table_cursor exec_info) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///entry: grn_hook_entry->Anonymous_0316ed98_e498_48dc_b3e5_e1b980ac0438
    ///offset: int
    ///proc: grn_obj*
    ///data: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_add_hook")]
public static extern  grn_rc grn_obj_add_hook(ref grn_ctx ctx, ref grn_table_cursor obj, grn_hook_entry entry, int offset, ref grn_table_cursor proc, ref grn_table_cursor data) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///entry: grn_hook_entry->Anonymous_0316ed98_e498_48dc_b3e5_e1b980ac0438
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_get_nhooks")]
public static extern  int grn_obj_get_nhooks(ref grn_ctx ctx, ref grn_table_cursor obj, grn_hook_entry entry) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///entry: grn_hook_entry->Anonymous_0316ed98_e498_48dc_b3e5_e1b980ac0438
    ///offset: int
    ///data: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_get_hook")]
public static extern  System.IntPtr grn_obj_get_hook(ref grn_ctx ctx, ref grn_table_cursor obj, grn_hook_entry entry, int offset, ref grn_table_cursor data) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    ///entry: grn_hook_entry->Anonymous_0316ed98_e498_48dc_b3e5_e1b980ac0438
    ///offset: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_delete_hook")]
public static extern  grn_rc grn_obj_delete_hook(ref grn_ctx ctx, ref grn_table_cursor obj, grn_hook_entry entry, int offset) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///type: unsigned char
    ///flags: grn_obj_flags->unsigned short
    ///domain: grn_id->unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_open")]
public static extern  System.IntPtr grn_obj_open(ref grn_ctx ctx, byte type, ushort flags, uint domain) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///column: grn_obj*
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    ///indexbuf: grn_obj**
    ///buf_size: int
    ///section: int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_column_index")]
public static extern  int grn_column_index(ref grn_ctx ctx, ref grn_table_cursor column, grn_operator op, ref System.IntPtr indexbuf, int buf_size, ref int section) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///db: grn_obj*
    ///id: grn_id->unsigned int
    ///removep: grn_bool->unsigned char
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_delete_by_id")]
public static extern  grn_rc grn_obj_delete_by_id(ref grn_ctx ctx, ref grn_table_cursor db, uint id, byte removep) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///db: grn_obj*
    ///id: grn_id->unsigned int
    ///buffer: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_path_by_id")]
public static extern  grn_rc grn_obj_path_by_id(ref grn_ctx ctx, ref grn_table_cursor db, uint id, System.IntPtr buffer) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///index: grn_obj*
    ///top_left_point: grn_obj*
    ///bottom_right_point: grn_obj*
    ///res: grn_obj*
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    [DllImportAttribute("groonga.dll", EntryPoint="grn_geo_select_in_rectangle")]
public static extern  grn_rc grn_geo_select_in_rectangle(ref grn_ctx ctx, ref grn_table_cursor index, ref grn_table_cursor top_left_point, ref grn_table_cursor bottom_right_point, ref grn_table_cursor res, grn_operator op) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///index: grn_obj*
    ///top_left_point: grn_obj*
    ///bottom_right_point: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_geo_estimate_in_rectangle")]
public static extern  int grn_geo_estimate_in_rectangle(ref grn_ctx ctx, ref grn_table_cursor index, ref grn_table_cursor top_left_point, ref grn_table_cursor bottom_right_point) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///index: grn_obj*
    ///top_left_point: grn_obj*
    ///bottom_right_point: grn_obj*
    ///offset: int
    ///limit: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_geo_cursor_open_in_rectangle")]
public static extern  System.IntPtr grn_geo_cursor_open_in_rectangle(ref grn_ctx ctx, ref grn_table_cursor index, ref grn_table_cursor top_left_point, ref grn_table_cursor bottom_right_point, int offset, int limit) ;

    
    /// Return Type: grn_posting*
    ///ctx: grn_ctx*
    ///cursor: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_geo_cursor_next")]
public static extern  System.IntPtr grn_geo_cursor_next(ref grn_ctx ctx, ref grn_table_cursor cursor) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///flags: int
    ///width: unsigned int
    ///max_results: unsigned int
    ///defaultopentag: char*
    ///defaultopentag_len: unsigned int
    ///defaultclosetag: char*
    ///defaultclosetag_len: unsigned int
    ///mapping: grn_snip_mapping*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_snip_open")]
public static extern  System.IntPtr grn_snip_open(ref grn_ctx ctx, int flags, uint width, uint max_results, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string defaultopentag, uint defaultopentag_len, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string defaultclosetag, uint defaultclosetag_len, ref grn_snip_mapping mapping) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///snip: grn_obj*
    ///keyword: char*
    ///keyword_len: unsigned int
    ///opentag: char*
    ///opentag_len: unsigned int
    ///closetag: char*
    ///closetag_len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_snip_add_cond")]
public static extern  grn_rc grn_snip_add_cond(ref grn_ctx ctx, ref grn_table_cursor snip, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string keyword, uint keyword_len, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string opentag, uint opentag_len, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string closetag, uint closetag_len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///snip: grn_obj*
    ///normalizer: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_snip_set_normalizer")]
public static extern  grn_rc grn_snip_set_normalizer(ref grn_ctx ctx, ref grn_table_cursor snip, ref grn_table_cursor normalizer) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///snip: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_snip_get_normalizer")]
public static extern  System.IntPtr grn_snip_get_normalizer(ref grn_ctx ctx, ref grn_table_cursor snip) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///snip: grn_obj*
    ///string: char*
    ///string_len: unsigned int
    ///nresults: unsigned int*
    ///max_tagged_len: unsigned int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_snip_exec")]
public static extern  grn_rc grn_snip_exec(ref grn_ctx ctx, ref grn_table_cursor snip, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string @string, uint string_len, ref uint nresults, ref uint max_tagged_len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///snip: grn_obj*
    ///index: int
    ///result: char*
    ///result_len: unsigned int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_snip_get_result")]
public static extern  grn_rc grn_snip_get_result(ref grn_ctx ctx, ref grn_table_cursor snip, int index, System.IntPtr result, ref uint result_len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///info: grn_logger_info*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_logger_info_set")]
public static extern  grn_rc grn_logger_info_set(ref grn_ctx ctx, ref grn_logger_info info) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///logger: grn_logger*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_logger_set")]
public static extern  grn_rc grn_logger_set(ref grn_ctx ctx, ref grn_logger logger) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///max_level: grn_log_level->Anonymous_1ceaa881_6549_4381_9e76_6c322e07a4ce
    [DllImportAttribute("groonga.dll", EntryPoint="grn_logger_set_max_level")]
public static extern  void grn_logger_set_max_level(ref grn_ctx ctx, grn_log_level max_level) ;

    
    /// Return Type: grn_log_level->Anonymous_1ceaa881_6549_4381_9e76_6c322e07a4ce
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_logger_get_max_level")]
public static extern  grn_log_level grn_logger_get_max_level(ref grn_ctx ctx) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_logger_reopen")]
public static extern  void grn_logger_reopen(ref grn_ctx ctx) ;

    
    /// Return Type: grn_bool->unsigned char
    ///ctx: grn_ctx*
    ///level: grn_log_level->Anonymous_1ceaa881_6549_4381_9e76_6c322e07a4ce
    [DllImportAttribute("groonga.dll", EntryPoint="grn_logger_pass")]
public static extern  byte grn_logger_pass(ref grn_ctx ctx, grn_log_level level) ;

    
    /// Return Type: void
    ///level: grn_log_level->Anonymous_1ceaa881_6549_4381_9e76_6c322e07a4ce
    [DllImportAttribute("groonga.dll", EntryPoint="grn_default_logger_set_max_level")]
public static extern  void grn_default_logger_set_max_level(grn_log_level level) ;

    
    /// Return Type: grn_log_level->Anonymous_1ceaa881_6549_4381_9e76_6c322e07a4ce
    [DllImportAttribute("groonga.dll", EntryPoint="grn_default_logger_get_max_level")]
public static extern  grn_log_level grn_default_logger_get_max_level() ;

    
    /// Return Type: void
    ///path: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_default_logger_set_path")]
public static extern  void grn_default_logger_set_path([InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path) ;

    
    /// Return Type: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_default_logger_get_path")]
public static extern  System.IntPtr grn_default_logger_get_path() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///logger: grn_query_logger*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_query_logger_set")]
public static extern  grn_rc grn_query_logger_set(ref grn_ctx ctx, ref grn_query_logger logger) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_query_logger_reopen")]
public static extern  void grn_query_logger_reopen(ref grn_ctx ctx) ;

    
    /// Return Type: grn_bool->unsigned char
    ///ctx: grn_ctx*
    ///flag: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_query_logger_pass")]
public static extern  byte grn_query_logger_pass(ref grn_ctx ctx, uint flag) ;

    
    /// Return Type: void
    ///flags: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_default_query_logger_set_flags")]
public static extern  void grn_default_query_logger_set_flags(uint flags) ;

    
    /// Return Type: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_default_query_logger_get_flags")]
public static extern  uint grn_default_query_logger_get_flags() ;

    
    /// Return Type: void
    ///path: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_default_query_logger_set_path")]
public static extern  void grn_default_query_logger_set_path([InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path) ;

    
    /// Return Type: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_default_query_logger_get_path")]
public static extern  System.IntPtr grn_default_query_logger_get_path() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_bulk_reinit")]
public static extern  grn_rc grn_bulk_reinit(ref grn_ctx ctx, ref grn_table_cursor bulk, uint size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///newsize: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_bulk_resize")]
public static extern  grn_rc grn_bulk_resize(ref grn_ctx ctx, ref grn_table_cursor bulk, uint newsize) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///str: char*
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_bulk_write")]
public static extern  grn_rc grn_bulk_write(ref grn_ctx ctx, ref grn_table_cursor bulk, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///str: char*
    ///from: unsigned int
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_bulk_write_from")]
public static extern  grn_rc grn_bulk_write_from(ref grn_ctx ctx, ref grn_table_cursor bulk, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint from, uint len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_bulk_reserve")]
public static extern  grn_rc grn_bulk_reserve(ref grn_ctx ctx, ref grn_table_cursor bulk, uint len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_bulk_space")]
public static extern  grn_rc grn_bulk_space(ref grn_ctx ctx, ref grn_table_cursor bulk, uint len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_bulk_truncate")]
public static extern  grn_rc grn_bulk_truncate(ref grn_ctx ctx, ref grn_table_cursor bulk, uint len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_bulk_fin")]
public static extern  grn_rc grn_bulk_fin(ref grn_ctx ctx, ref grn_table_cursor bulk) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///i: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_itoa")]
public static extern  grn_rc grn_text_itoa(ref grn_ctx ctx, ref grn_table_cursor bulk, int i) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///i: int
    ///ch: char
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_itoa_padded")]
public static extern  grn_rc grn_text_itoa_padded(ref grn_ctx ctx, ref grn_table_cursor bulk, int i, byte ch, uint len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///param2: int
    ///i: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_lltoa")]
public static extern  grn_rc grn_text_lltoa(ref grn_ctx ctx, ref grn_table_cursor bulk, int param2, int i) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///d: double
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_ftoa")]
public static extern  grn_rc grn_text_ftoa(ref grn_ctx ctx, ref grn_table_cursor bulk, double d) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///i: int
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_itoh")]
public static extern  grn_rc grn_text_itoh(ref grn_ctx ctx, ref grn_table_cursor bulk, int i, uint len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///id: grn_id->unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_itob")]
public static extern  grn_rc grn_text_itob(ref grn_ctx ctx, ref grn_table_cursor bulk, uint id) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///param2: int
    ///i: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_lltob32h")]
public static extern  grn_rc grn_text_lltob32h(ref grn_ctx ctx, ref grn_table_cursor bulk, int param2, int i) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///v: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_benc")]
public static extern  grn_rc grn_text_benc(ref grn_ctx ctx, ref grn_table_cursor bulk, uint v) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///s: char*
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_esc")]
public static extern  grn_rc grn_text_esc(ref grn_ctx ctx, ref grn_table_cursor bulk, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string s, uint len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///buf: grn_obj*
    ///str: char*
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_urlenc")]
public static extern  grn_rc grn_text_urlenc(ref grn_ctx ctx, ref grn_table_cursor buf, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint len) ;

    
    /// Return Type: char*
    ///ctx: grn_ctx*
    ///buf: grn_obj*
    ///s: char*
    ///e: char*
    ///d: char
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_urldec")]
public static extern  System.IntPtr grn_text_urldec(ref grn_ctx ctx, ref grn_table_cursor buf, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string s, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string e, byte d) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///buf: grn_obj*
    ///s: char*
    ///len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_escape_xml")]
public static extern  grn_rc grn_text_escape_xml(ref grn_ctx ctx, ref grn_table_cursor buf, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string s, uint len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///sec: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_time2rfc1123")]
public static extern  grn_rc grn_text_time2rfc1123(ref grn_ctx ctx, ref grn_table_cursor bulk, int sec) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///format: char*
    ///args: va_list->char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_vprintf")]
public static extern  grn_rc grn_text_vprintf(ref grn_ctx ctx, ref grn_table_cursor bulk, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string format, System.IntPtr args) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///outbuf: grn_obj*
    ///output_type: grn_content_type->Anonymous_b1f83d5a_f823_4c0f_b538_51d4fa8c63dc
    ///obj: grn_obj*
    ///format: grn_obj_format*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_output_obj")]
public static extern  void grn_output_obj(ref grn_ctx ctx, ref grn_table_cursor outbuf, grn_content_type output_type, ref grn_table_cursor obj, ref grn_obj_format format) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///rc: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///head: grn_obj*
    ///body: grn_obj*
    ///foot: grn_obj*
    ///file: char*
    ///line: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_output_envelope")]
public static extern  void grn_output_envelope(ref grn_ctx ctx, grn_rc rc, ref grn_table_cursor head, ref grn_table_cursor body, ref grn_table_cursor foot, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string file, int line) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///name: char*
    ///nelements: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_array_open")]
public static extern  void grn_ctx_output_array_open(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, int nelements) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_array_close")]
public static extern  void grn_ctx_output_array_close(ref grn_ctx ctx) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///name: char*
    ///nelements: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_map_open")]
public static extern  void grn_ctx_output_map_open(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, int nelements) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_map_close")]
public static extern  void grn_ctx_output_map_close(ref grn_ctx ctx) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///value: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_int32")]
public static extern  void grn_ctx_output_int32(ref grn_ctx ctx, int value) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///param1: int
    ///value: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_int64")]
public static extern  void grn_ctx_output_int64(ref grn_ctx ctx, int param1, int value) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///value: double
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_float")]
public static extern  void grn_ctx_output_float(ref grn_ctx ctx, double value) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///value: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_cstr")]
public static extern  void grn_ctx_output_cstr(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string value) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///value: char*
    ///value_len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_str")]
public static extern  void grn_ctx_output_str(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string value, uint value_len) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///value: grn_bool->unsigned char
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_bool")]
public static extern  void grn_ctx_output_bool(ref grn_ctx ctx, byte value) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///value: grn_obj*
    ///format: grn_obj_format*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_output_obj")]
public static extern  void grn_ctx_output_obj(ref grn_ctx ctx, ref grn_table_cursor value, ref grn_obj_format format) ;

    
    /// Return Type: char*
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_get_mime_type")]
public static extern  System.IntPtr grn_ctx_get_mime_type(ref grn_ctx ctx) ;

    
    /// Return Type: void
    ///param0: grn_ctx*
	///func: Anonymous_ctx_proc_func
    ///func_arg: void*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_recv_handler_set")]
	public static extern  void grn_ctx_recv_handler_set(ref grn_ctx param0, Anonymous_ctx_proc_func func, System.IntPtr func_arg) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///bulk: grn_obj*
    ///obj: grn_obj*
    ///format: grn_obj_format*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_text_otoj")]
public static extern  grn_rc grn_text_otoj(ref grn_ctx ctx, ref grn_table_cursor bulk, ref grn_table_cursor obj, ref grn_obj_format format) ;

    
    /// Return Type: void
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_time_now")]
public static extern  void grn_time_now(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_str*
    ///ctx: grn_ctx*
    ///str: char*
    ///str_len: unsigned int
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_str_open")]
public static extern  System.IntPtr grn_str_open(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint str_len, int flags) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///nstr: grn_str*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_str_close")]
public static extern  grn_rc grn_str_close(ref grn_ctx ctx, ref grn_str nstr) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///string: char*
    ///length_in_bytes: unsigned int
    ///normalizer: grn_obj*
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_open")]
public static extern  System.IntPtr grn_string_open(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string @string, uint length_in_bytes, ref grn_table_cursor normalizer, int flags) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///string: grn_obj*
    ///original: char**
    ///length_in_bytes: unsigned int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_get_original")]
public static extern  grn_rc grn_string_get_original(ref grn_ctx ctx, ref grn_table_cursor @string, ref System.IntPtr original, ref uint length_in_bytes) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///string: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_get_flags")]
public static extern  int grn_string_get_flags(ref grn_ctx ctx, ref grn_table_cursor @string) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///string: grn_obj*
    ///normalized: char**
    ///length_in_bytes: unsigned int*
    ///n_characters: unsigned int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_get_normalized")]
public static extern  grn_rc grn_string_get_normalized(ref grn_ctx ctx, ref grn_table_cursor @string, ref System.IntPtr normalized, ref uint length_in_bytes, ref uint n_characters) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///string: grn_obj*
    ///normalized: char*
    ///length_in_bytes: unsigned int
    ///n_characters: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_set_normalized")]
public static extern  grn_rc grn_string_set_normalized(ref grn_ctx ctx, ref grn_table_cursor @string, System.IntPtr normalized, uint length_in_bytes, uint n_characters) ;

    
    /// Return Type: short*
    ///ctx: grn_ctx*
    ///string: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_get_checks")]
public static extern  System.IntPtr grn_string_get_checks(ref grn_ctx ctx, ref grn_table_cursor @string) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///string: grn_obj*
    ///checks: short*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_set_checks")]
public static extern  grn_rc grn_string_set_checks(ref grn_ctx ctx, ref grn_table_cursor @string, ref short checks) ;

    
    /// Return Type: char*
    ///ctx: grn_ctx*
    ///string: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_get_types")]
public static extern  System.IntPtr grn_string_get_types(ref grn_ctx ctx, ref grn_table_cursor @string) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///string: grn_obj*
    ///types: unsigned char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_set_types")]
public static extern  grn_rc grn_string_set_types(ref grn_ctx ctx, ref grn_table_cursor @string, System.IntPtr types) ;

    
    /// Return Type: grn_encoding->Anonymous_4cc9cdbc_7025_4e0d_86b2_46372051bb24
    ///ctx: grn_ctx*
    ///string: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_string_get_encoding")]
public static extern  grn_encoding grn_string_get_encoding(ref grn_ctx ctx, ref grn_table_cursor @string) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///str: char*
    ///end: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_charlen")]
public static extern  int grn_charlen(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string end) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///name: char*
    ///name_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_create")]
public static extern  System.IntPtr grn_expr_create(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_close")]
public static extern  grn_rc grn_expr_close(ref grn_ctx ctx, ref grn_table_cursor expr) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///name: char*
    ///name_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_add_var")]
public static extern  System.IntPtr grn_expr_add_var(ref grn_ctx ctx, ref grn_table_cursor expr, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///name: char*
    ///name_size: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_get_var")]
public static extern  System.IntPtr grn_expr_get_var(ref grn_ctx ctx, ref grn_table_cursor expr, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///offset: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_get_var_by_offset")]
public static extern  System.IntPtr grn_expr_get_var_by_offset(ref grn_ctx ctx, ref grn_table_cursor expr, uint offset) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///obj: grn_obj*
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    ///nargs: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_append_obj")]
public static extern  System.IntPtr grn_expr_append_obj(ref grn_ctx ctx, ref grn_table_cursor expr, ref grn_table_cursor obj, grn_operator op, int nargs) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///obj: grn_obj*
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    ///nargs: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_append_const")]
public static extern  System.IntPtr grn_expr_append_const(ref grn_ctx ctx, ref grn_table_cursor expr, ref grn_table_cursor obj, grn_operator op, int nargs) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///str: char*
    ///str_size: unsigned int
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    ///nargs: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_append_const_str")]
public static extern  System.IntPtr grn_expr_append_const_str(ref grn_ctx ctx, ref grn_table_cursor expr, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint str_size, grn_operator op, int nargs) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///i: int
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    ///nargs: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_append_const_int")]
public static extern  System.IntPtr grn_expr_append_const_int(ref grn_ctx ctx, ref grn_table_cursor expr, int i, grn_operator op, int nargs) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    ///nargs: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_append_op")]
public static extern  grn_rc grn_expr_append_op(ref grn_ctx ctx, ref grn_table_cursor expr, grn_operator op, int nargs) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///query: char*
    ///query_size: int
    ///target_characters: char*
    ///escape_character: char
    ///escaped_query: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_syntax_escape")]
public static extern  grn_rc grn_expr_syntax_escape(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string query, int query_size, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string target_characters, byte escape_character, ref grn_table_cursor escaped_query) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///query: char*
    ///query_size: int
    ///escaped_query: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_syntax_escape_query")]
public static extern  grn_rc grn_expr_syntax_escape_query(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string query, int query_size, ref grn_table_cursor escaped_query) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_compile")]
public static extern  grn_rc grn_expr_compile(ref grn_ctx ctx, ref grn_table_cursor expr) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///nargs: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_exec")]
public static extern  System.IntPtr grn_expr_exec(ref grn_ctx ctx, ref grn_table_cursor expr, int nargs) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///obj: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_push")]
public static extern  grn_rc grn_ctx_push(ref grn_ctx ctx, ref grn_table_cursor obj) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_pop")]
public static extern  System.IntPtr grn_ctx_pop(ref grn_ctx ctx) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///domain: grn_id->unsigned int
    ///flags: grn_obj_flags->unsigned short
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_alloc")]
public static extern  System.IntPtr grn_expr_alloc(ref grn_ctx ctx, ref grn_table_cursor expr, uint domain, ushort flags) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///expr: grn_obj*
    ///res: grn_obj*
    ///op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_select")]
public static extern  System.IntPtr grn_table_select(ref grn_ctx ctx, ref grn_table_cursor table, ref grn_table_cursor expr, ref grn_table_cursor res, grn_operator op) ;

    
    /// Return Type: int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///str: char*
    ///str_size: unsigned int
    ///res: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_obj_columns")]
public static extern  int grn_obj_columns(ref grn_ctx ctx, ref grn_table_cursor table, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint str_size, ref grn_table_cursor res) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///str: char*
    ///str_size: unsigned int
    ///default_column: grn_obj*
    ///default_mode: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    ///default_op: grn_operator->Anonymous_0afd231f_39e8_44cf_9c60_faf840d89fa2
    ///flags: grn_expr_flags->unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_parse")]
public static extern  grn_rc grn_expr_parse(ref grn_ctx ctx, ref grn_table_cursor expr, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint str_size, ref grn_table_cursor default_column, grn_operator default_mode, grn_operator default_op, uint flags) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///flags: int
    ///width: unsigned int
    ///max_results: unsigned int
    ///n_tags: unsigned int
    ///opentags: char**
    ///opentag_lens: unsigned int*
    ///closetags: char**
    ///closetag_lens: unsigned int*
    ///mapping: grn_snip_mapping*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_snip")]
public static extern  System.IntPtr grn_expr_snip(ref grn_ctx ctx, ref grn_table_cursor expr, int flags, uint width, uint max_results, uint n_tags, ref System.IntPtr opentags, ref uint opentag_lens, ref System.IntPtr closetags, ref uint closetag_lens, ref grn_snip_mapping mapping) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///expr: grn_obj*
    ///snip: grn_obj*
    ///n_tags: unsigned int
    ///opentags: char**
    ///opentag_lens: unsigned int*
    ///closetags: char**
    ///closetag_lens: unsigned int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_expr_snip_add_conditions")]
public static extern  grn_rc grn_expr_snip_add_conditions(ref grn_ctx ctx, ref grn_table_cursor expr, ref grn_table_cursor snip, uint n_tags, ref System.IntPtr opentags, ref uint opentag_lens, ref System.IntPtr closetags, ref uint closetag_lens) ;

    
    /// Return Type: grn_table_sort_key*
    ///ctx: grn_ctx*
    ///str: char*
    ///str_size: unsigned int
    ///table: grn_obj*
    ///nkeys: unsigned int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_sort_key_from_str")]
public static extern  System.IntPtr grn_table_sort_key_from_str(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint str_size, ref grn_table_cursor table, ref uint nkeys) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///keys: grn_table_sort_key*
    ///nkeys: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_sort_key_close")]
public static extern  grn_rc grn_table_sort_key_close(ref grn_ctx ctx, ref grn_table_sort_key keys, uint nkeys) ;

    
    /// Return Type: grn_bool->unsigned char
    ///ctx: grn_ctx*
    ///table: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_is_grouped")]
public static extern  byte grn_table_is_grouped(ref grn_ctx ctx, ref grn_table_cursor table) ;

    
    /// Return Type: unsigned int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_max_n_subrecs")]
public static extern  uint grn_table_max_n_subrecs(ref grn_ctx ctx, ref grn_table_cursor table) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///name: char*
    ///name_size: unsigned int
    ///path: char*
    ///group_key: grn_obj*
    ///value_type: grn_obj*
    ///max_n_subrecs: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_create_for_group")]
public static extern  System.IntPtr grn_table_create_for_group(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint name_size, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path, ref grn_table_cursor group_key, ref grn_table_cursor value_type, uint max_n_subrecs) ;

    
    /// Return Type: unsigned int
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///id: grn_id->unsigned int
    ///subrecbuf: grn_id*
    ///scorebuf: int*
    ///buf_size: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_get_subrecs")]
public static extern  uint grn_table_get_subrecs(ref grn_ctx ctx, ref grn_table_cursor table, uint id, ref uint subrecbuf, ref int scorebuf, int buf_size) ;

    
    /// Return Type: grn_obj*
    ///ctx: grn_ctx*
    ///table: grn_obj*
    ///str: char*
    ///str_len: unsigned int
    ///buf: grn_obj*
    ///addp: grn_bool->unsigned char
    [DllImportAttribute("groonga.dll", EntryPoint="grn_table_tokenize")]
public static extern  System.IntPtr grn_table_tokenize(ref grn_ctx ctx, ref grn_table_cursor table, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint str_len, ref grn_table_cursor buf, byte addp) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///input_type: grn_content_type->Anonymous_b1f83d5a_f823_4c0f_b538_51d4fa8c63dc
    ///table: char*
    ///table_len: unsigned int
    ///columns: char*
    ///columns_len: unsigned int
    ///values: char*
    ///values_len: unsigned int
    ///ifexists: char*
    ///ifexists_len: unsigned int
    ///each: char*
    ///each_len: unsigned int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_load")]
public static extern  grn_rc grn_load(ref grn_ctx ctx, grn_content_type input_type, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string table, uint table_len, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string columns, uint columns_len, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string values, uint values_len, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string ifexists, uint ifexists_len, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string each, uint each_len) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///host: char*
    ///port: int
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_connect")]
public static extern  grn_rc grn_ctx_connect(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string host, int port, int flags) ;

    
    /// Return Type: unsigned int
    ///ctx: grn_ctx*
    ///str: char*
    ///str_len: unsigned int
    ///flags: int
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_send")]
public static extern  uint grn_ctx_send(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string str, uint str_len, int flags) ;

    
    /// Return Type: unsigned int
    ///ctx: grn_ctx*
    ///str: char**
    ///str_len: unsigned int*
    ///flags: int*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_recv")]
public static extern  uint grn_ctx_recv(ref grn_ctx ctx, ref System.IntPtr str, ref uint str_len, ref int flags) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///info: grn_ctx_info*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_ctx_info_get")]
public static extern  grn_rc grn_ctx_info_get(ref grn_ctx ctx, ref grn_ctx_info info) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    [DllImportAttribute("groonga.dll", EntryPoint="grn_set_segv_handler")]
public static extern  grn_rc grn_set_segv_handler() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    [DllImportAttribute("groonga.dll", EntryPoint="grn_set_int_handler")]
public static extern  grn_rc grn_set_int_handler() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    [DllImportAttribute("groonga.dll", EntryPoint="grn_set_term_handler")]
public static extern  grn_rc grn_set_term_handler() ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///path: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_pat_remove")]
public static extern  grn_rc grn_pat_remove(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path) ;

    
    /// Return Type: grn_rc->Anonymous_19e5c9fd_16cd_42c7_8739_9e6ced81389a
    ///ctx: grn_ctx*
    ///path: char*
    [DllImportAttribute("groonga.dll", EntryPoint="grn_dat_remove")]
public static extern  grn_rc grn_dat_remove(ref grn_ctx ctx, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string path) ;

}
